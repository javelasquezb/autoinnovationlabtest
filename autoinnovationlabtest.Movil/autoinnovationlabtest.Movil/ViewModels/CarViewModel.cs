namespace autoinnovationlabtest.Movil.ViewModels
{
    public class CarViewModel : BaseViewModel
    {
        #region Attributes
        private string _model;
        private string _year;
        private string _brand;


        #endregion



        #region Properties
        public string Model { get => _model; set => SetValue(ref _model,value); }
        public string Year { get => _year; set => SetValue(ref _year,value); }
        public string Brand { get => _brand; set => SetValue(ref _brand,value); }

        #endregion

        #region Commands
        #endregion

        #region Methods

        public void Load(CarItemViewModel car)
        {
            Model = car.Model;
            Year = car.Year;
            Brand = car.Brand;
        }

        #endregion
    }
}
