using autoinnovationlabtest.Data.Entities;
using autoinnovationlabtest.Data.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace autoinnovationlabtest.Data.Repositories
{
    public class CarRepository : GenericRepository<Car>, ICarRepository
    {
        private readonly DataContext _context;

        public CarRepository(DataContext context) : base(context)
        {
            _context = context;
        }

        public async Task<Car> GetAllInfo(int id) => await _context.Cars.AsNoTracking().Include(c => c.Brand).Where(c => c.Id == id).FirstOrDefaultAsync();
    }
}
