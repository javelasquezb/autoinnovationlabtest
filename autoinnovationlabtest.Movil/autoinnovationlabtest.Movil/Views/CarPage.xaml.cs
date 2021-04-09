using autoinnovationlabtest.Movil.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace autoinnovationlabtest.Movil.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CarPage : ContentPage
    {
        private readonly CarItemViewModel _carItemViewModel;

        public CarPage(CarItemViewModel carItemViewModel)
        {
            InitializeComponent();
            BindingContext = Startup.ServiceProvider.GetService<CarViewModel>();
            _carItemViewModel = carItemViewModel;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            ((CarViewModel)BindingContext).Load(_carItemViewModel);
        }
    }
}