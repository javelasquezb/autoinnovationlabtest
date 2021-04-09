using autoinnovationlabtest.Movil.Views;
using Xamarin.Forms;

namespace autoinnovationlabtest.Movil
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            Startup.Init();
            MainPage = new CarsPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
