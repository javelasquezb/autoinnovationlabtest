namespace autoinnovationlabtest.Data.Entities
{
    /// <summary>
    /// Nombre de la clase: Brand
    /// Clase representativa de la tabla Brands de la base de datos
    /// </summary>
    public class Brand : IEntity
    {
        /// <summary>
        /// Propiedad Id
        /// LLave primaria de la tabla
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Propiedad Name
        /// Nombre representativo del Brand
        /// </summary>
        public string Name { get; set; }
    }
}
