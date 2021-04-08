using autoinnovationlabtest.Common.Api;
using System.Threading.Tasks;

namespace autoinnovationlabtest.Common.Services
{
    /// <summary>
    /// Nombre de la interfaz : IApiService
    /// </summary>
    public interface IApiService
    {
        /// <summary>
        /// Firma de metodo para la invocacion de metodos get del api
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        Task<Response> GetAsync(string url);
        /// <summary>
        /// Firma de metodo para la invocacion de metodos post del api
        /// </summary>
        /// <param name="url"></param>
        /// <param name="pObject"></param>
        /// <returns></returns>
        Task<Response> PostAsync(string url,object pObject);
    }
}
