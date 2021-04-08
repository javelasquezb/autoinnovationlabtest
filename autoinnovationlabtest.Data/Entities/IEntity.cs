namespace autoinnovationlabtest.Data.Entities
{
    /// <summary>
    /// Nombre de la interfaz: IEntity
    /// Interfaz con los atributos iguales de todas las tablas de la base de datos
    /// </summary>
    public interface IEntity
    {
        /// <summary>
        /// LLave primaria de la tabla
        /// </summary>
        int Id { get; set; }
        
    }
}
