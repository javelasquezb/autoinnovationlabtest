using autoinnovationlabtest.Movil.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace autoinnovationlabtest.Movil.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CarsPage : ContentPage
    {
        public CarsPage()
        {
            InitializeComponent();
            BindingContext = Startup.ServiceProvider.GetService<CarsViewModel>();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            ((CarsViewModel)BindingContext).Navigation = Navigation;
            ((CarsViewModel)BindingContext).Load();
        }
    }
}