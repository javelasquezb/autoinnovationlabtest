using autoinnovationlabtest.Common.Api;
using System.Threading.Tasks;

namespace autoinnovationlabtest.Business.Brands
{
    public interface IBrandManager
    {
        Task<Response> GetAll();
    }
}
