using autoinnovationlabtest.Common.Api;
using autoinnovationlabtest.Common.Models;
using System.Threading.Tasks;

namespace autoinnovationlabtest.Common.Services.Cars
{
    /// <summary>
    /// Nombre de la interfaz:ICarServices
    /// Interfaz que posee todos los metodos para conectarse al api
    /// </summary>
    public interface ICarService : IUrlBase
    {
        /// <summary>
        /// Firma de metodo para consultar todos los registros
        /// </summary>
        /// <returns>Objeto de tipo Response</returns>
        Task<Response> GetAll();
        /// <summary>
        /// Firma de metodo para consultar un registro con toda la informacion
        /// </summary>
        /// <param name="car">Objeto de tipo Common.Models.Car</param>
        /// <returns>Objeto de tipo Response</returns>
        Task<Response> GetAllInformation(Car car);
    }
}
