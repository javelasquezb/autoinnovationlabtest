namespace autoinnovationlabtest.Data.Entities
{
    /// <summary>
    /// Nombre de la clase: Car
    /// Clase representativa de la tabla Cars
    /// </summary>
    public class Car : IEntity
    {
        /// <summary>
        /// Propiedad Id
        /// LLave primaria de la tabla
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Propiedad Model
        /// Modelo del carro
        /// </summary>
        public string Model { get; set; }
        /// <summary>
        /// Propiedad Year
        /// A;o del carro
        /// </summary>
        public int Year { get; set; }
        /// <summary>
        /// Propiedad BrandId
        /// Id relacionado al Brand
        /// </summary>
        public int BrandId { get; set; }
        /// <summary>
        /// Propiedad Brand
        /// Brand relacionado a la clase
        /// </summary>
        public virtual Brand Brand { get; set; }
    }
}
