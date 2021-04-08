namespace autoinnovationlabtest.Common.Models
{
    /// <summary>
    /// Nombre de la clase: Car
    /// Clase representativa de Car con toda su informacion enviada por el api para el entendimiento de los clientes
    /// </summary>
    public class Car
    {
        /// <summary>
        /// Propiedad Id
        /// Identificador del registro
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Propiedad Model
        /// Nombre del modelo del carro
        /// </summary>
        public string Model { get; set; }
        /// <summary>
        /// Propiedad Year
        /// Año del carro
        /// </summary>
        public string Year { get; set; }
        /// <summary>
        /// Propiedad Brand
        /// Nombre de la marca del carro
        /// </summary>
        public string Brand { get; set; }
    }
}
