using autoinnovationlabtest.Common.Models;
using autoinnovationlabtest.Common.Services.Cars;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace autoinnovationlabtest.Movil.ViewModels
{
    public class CarsViewModel : BaseViewModel
    {

        #region Attributes
        public INavigation Navigation { get; set; }
        private readonly ICarService _carService;
        private List<CarItemViewModel> _cars;
        private bool _isRefreshing;
        #endregion

        public CarsViewModel(ICarService carService)
        {
            _carService = carService;
            var urlBase = App.Current.Resources["UrlApi"].ToString();
            _carService.UrlBase = urlBase;
        }

        #region Properties
        public List<CarItemViewModel> Cars
        {
            get => _cars;
            set => SetValue(ref _cars,value);
        }
        public bool IsRefreshing
        {
            get => _isRefreshing;
            set => SetValue(ref _isRefreshing,value);
        }

        #endregion

        #region Commands
        #endregion

        #region Methods

        public async void Load()
        {
            await this.LoadCars();
        }

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
