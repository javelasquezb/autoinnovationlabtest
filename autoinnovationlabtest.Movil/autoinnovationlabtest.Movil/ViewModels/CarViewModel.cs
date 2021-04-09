namespace autoinnovationlabtest.Movil.ViewModels
{
    /// <summary>
    /// Nombre de la clase:CarViewModel
    /// Clase para representar la vista de Detalle del carro
    /// </summary>
    public class CarViewModel : BaseViewModel
    {
        #region Attributes
        //Variable para indicar el Modelo del carro
        private string _model;
        //Variable para indicar el A;o del carro
        private string _year;
        //Variable par indicar la Marca del Carro
        private string _brand;


        #endregion



        #region Properties
        /// <summary>
        /// Propiedad Model
        /// </summary>
        public string Model { get => _model; set => SetValue(ref _model,value); }
        /// <summary>
        /// Propiedad Year
        /// </summary>
        public string Year { get => _year; set => SetValue(ref _year,value); }
        /// <summary>
        /// Propiedad Brand
        /// </summary>
        public string Brand { get => _brand; set => SetValue(ref _brand,value); }

        #endregion

        #region Commands
        #endregion

        #region Methods

        /// <summary>
        /// Metodo para realizar la carga del detalle en la vista del carro seleccionado
        /// </summary>
        /// <param name="car"></param>
        public void Load(CarItemViewModel car)
        {
            Model = car.Model;
            Year = car.Year;
            Brand = car.Brand;
        }

        #endregion
    }
}
