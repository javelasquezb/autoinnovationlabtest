using autoinnovationlabtest.Common.Models;
using autoinnovationlabtest.Movil.Views;
using Prism.Commands;
using Xamarin.Forms;

namespace autoinnovationlabtest.Movil.ViewModels
{
    public class CarItemViewModel : Car
    {

        #region Attributes
        private readonly INavigation _navigation;
        private DelegateCommand _selectCarCommand;
        #endregion

        public CarItemViewModel(INavigation navigation)
        {
            _navigation = navigation;
        }

        #region Properties
        #endregion

        #region Commands
        public DelegateCommand SelectCarCommand => _selectCarCommand ?? (_selectCarCommand = new DelegateCommand(SelectCar));


        #endregion

        #region Methods
        private async void SelectCar()
        {

            await _navigation.PushAsync(new NavigationPage(new CarPage(this)),true);
        }
        #endregion
    }
}
