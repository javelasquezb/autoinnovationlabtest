using autoinnovationlabtest.Data.Entities;
using autoinnovationlabtest.Data.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace autoinnovationlabtest.Data.Repositories
{
    /// <summary>
    /// Nombre de la clase: CarRepository
    /// Clase con la implementacion de todos los metodos permitidos para operar con la Brand
    /// </summary>
    public class CarRepository : GenericRepository<Car>, ICarRepository
    {
        //Variable para operar con los datos de la base de datos
        private readonly DataContext _context;

        /// <summary>
        /// Constructor de la clase
        /// </summary>
        /// <param name="context">Objeto de tipo DataContext</param>
        public CarRepository(DataContext context) : base(context)
        {
            _context = context;
        }

        /// <summary>
        /// Implementacion del metodo GetAllInfo
        /// </summary>
        /// <param name="id">int con el valor a consultar</param>
        /// <returns>Objeto de tipo Car</returns>
        public async Task<Car> GetAllInfo(int id) => await _context.Cars.AsNoTracking().Include(c => c.Brand).Where(c => c.Id == id).FirstOrDefaultAsync();
    }
}
