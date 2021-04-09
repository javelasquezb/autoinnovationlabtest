using autoinnovationlabtest.Common.Models;
using autoinnovationlabtest.Common.Services.Cars;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace autoinnovationlabtest.Movil.ViewModels
{
    /// <summary>
    /// Nombre de la clase: CarsViewModel
    /// Clase con el listado de Cars para la vista
    /// </summary>
    public class CarsViewModel : BaseViewModel
    {

        #region Attributes
        //Variable para la navegacion
        public INavigation Navigation { get; set; }
        //Variable para realizar solicitudes al api
        private readonly ICarService _carService;
        //Variable con el listado de Carras
        private List<CarItemViewModel> _cars;
        //Variable para la espera de la carga de datos
        private bool _isRefreshing;
        #endregion

        /// <summary>
        /// COnstructor de la clase
        /// </summary>
        /// <param name="carService"></param>
        public CarsViewModel(ICarService carService)
        {
            _carService = carService;
            var urlBase = App.Current.Resources["UrlApi"].ToString();
            _carService.UrlBase = urlBase;
        }

        #region Properties
        /// <summary>
        /// Propiedad Cars
        /// Listado de carros con el set del comando
        /// </summary>
        public List<CarItemViewModel> Cars
        {
            get => _cars;
            set => SetValue(ref _cars,value);
        }
        /// <summary>
        /// Propiedad IsRefreshing
        /// Para indicar la carga de datos
        /// </summary>
        public bool IsRefreshing
        {
            get => _isRefreshing;
            set => SetValue(ref _isRefreshing,value);
        }

        #endregion

        #region Commands
        #endregion

        #region Methods

        /// <summary>
        /// Metodod para realizar la carga de datos
        /// </summary>
        public async void Load()
        {
            await this.LoadCars();
        }

        /// <summary>
        /// Metodo para realizar la carga de datos de carros desde el api
        /// </summary>
        /// <returns></returns>
        private async Task LoadCars()
        {
            IsRefreshing = true;
            var response = await _carService.GetAll();
            IsRefreshing = false;
            if (response.IsSucced)
            {
                var cars = JsonConvert.DeserializeObject<List<Car>>(response.Result.ToString());
                Cars = cars
                    .OrderBy(c => c.Model)
                    .Select(c => new CarItemViewModel(this.Navigation)
                    {
                        Id = c.Id,
                        Brand = c.Brand,
                        Model = c.Model,
                        Year = c.Year
                    })
                    .ToList();
            }
            else
            {
                await App.Current.MainPage.DisplayAlert("Informacion",response.Message,"Ok");
            }
        }
        #endregion

    }
}
