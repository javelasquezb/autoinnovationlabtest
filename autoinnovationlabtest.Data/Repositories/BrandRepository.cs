using autoinnovationlabtest.Data.Entities;
using autoinnovationlabtest.Data.Repositories.Interfaces;

namespace autoinnovationlabtest.Data.Repositories
{
    /// <summary>
    /// Nombre de la clase: BrandRepository
    /// Clase con la implementacion de los metodos permitidos para operar con la tabla Brands
    /// </summary>
    public class BrandRepository : GenericRepository<Brand>, IBrandRepository
    {
        /// <summary>
        /// Constructor de la clase
        /// </summary>
        /// <param name="context">Objeto de tipo DataContext contexto de la base de datos</param>
        public BrandRepository(DataContext context) : base(context)
        {
        }
    }
}
