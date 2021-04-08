using autoinnovationlabtest.Common.Api;
using System.Threading.Tasks;

namespace autoinnovationlabtest.Common.Services.Brands
{
    public interface IBrandService : IUrlBase
    {
        Task<Response> GetAll();
    }
}
