using autoinnovationlabtest.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace autoinnovationlabtest.Data
{
    /// <summary>
    /// Nombre de la clase: DataContext
    /// Clase para indicar el contexto de la base de datos
    /// </summary>
    public class DataContext : DbContext
    {
        /// <summary>
        /// Constructor de la clase
        /// </summary>
        /// <param name="options">Objeto de tipo DbContextOptions con las opciones configuradas de la base de datos</param>
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        /// <summary>
        /// Propiedad Brands
        /// Relacionada a la tabla Brands de la base de datos
        /// </summary>
        public DbSet<Brand> Brands { get; set; }
        /// <summary>
        /// Propiedad Cars
        /// Relacionada a la tabla Cars de la base de datos
        /// </summary>
        public DbSet<Car> Cars { get; set; }
    }
}
