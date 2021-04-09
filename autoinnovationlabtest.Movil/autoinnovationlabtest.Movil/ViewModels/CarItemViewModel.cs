using autoinnovationlabtest.Common.Models;
using autoinnovationlabtest.Movil.Views;
using Prism.Commands;
using Xamarin.Forms;

namespace autoinnovationlabtest.Movil.ViewModels
{
    /// <summary>
    /// Nombre de la clase: CarItemViewModel
    /// Clase usada para listar los carros en el List View
    /// </summary>
    public class CarItemViewModel : Car
    {

        #region Attributes
        //Variable para realizar la navegacion
        private readonly INavigation _navigation;
        //variable para realizar la navegacion
        private DelegateCommand _selectCarCommand;
        #endregion

        /// <summary>
        /// Constructor de la clase
        /// </summary>
        /// <param name="navigation"></param>
        public CarItemViewModel(INavigation navigation)
        {
            _navigation = navigation;
        }

        #region Properties
        #endregion

        #region Commands
        /// <summary>
        /// Propiedad SelectCarCommand
        /// Comando bindiado en el carItem del list view para indicar la accion al interactuar con el elemento
        /// </summary>
        public DelegateCommand SelectCarCommand => _selectCarCommand ?? (_selectCarCommand = new DelegateCommand(SelectCar));


        #endregion

        #region Methods
        /// <summary>
        /// Metodo al seleccionar elemento navegar a la pagina detalle
        /// </summary>
        private async void SelectCar()
        {

            await _navigation.PushAsync(new NavigationPage(new CarPage(this)),true);
        }
        #endregion
    }
}
