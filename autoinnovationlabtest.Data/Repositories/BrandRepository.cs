using autoinnovationlabtest.Data.Entities;
using autoinnovationlabtest.Data.Repositories.Interfaces;

namespace autoinnovationlabtest.Data.Repositories
{
    public class BrandRepository : GenericRepository<Brand>, IBrandRepository
    {
        public BrandRepository(DataContext context) : base(context)
        {
        }
    }
}
