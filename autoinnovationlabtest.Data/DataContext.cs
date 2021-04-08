using autoinnovationlabtest.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace autoinnovationlabtest.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Brand> Brands { get; set; }
        public DbSet<Car> Cars { get; set; }
    }
}
