using autoinnovationlabtest.Common.Api;
using autoinnovationlabtest.Common.Models;
using System.Threading.Tasks;

namespace autoinnovationlabtest.Business.Cars
{
    /// <summary>
    /// Nombre de la interfaz:ICarManager
    /// Interfaz con las firmas de metodos necesarios para la interaccion con la clase Car
    /// </summary>
    public interface ICarManager
    {
        /// <summary>
        /// Firma de metodo para obtener todos los registros de Car
        /// </summary>
        /// <returns>Objeto de tipo Response con la respuesta de la operacion</returns>
        Task<Response> GetAll();
        /// <summary>
        /// Firma de metodo para obtener el registro de Car
        /// </summary>
        /// <param name="car">Objeto de tipo Car con el id a consultar</param>
        /// <returns>Objeto de tipo Response con la respuesta de la operacion</returns>
        Task<Response> GetAllInformation(Car car);
    }
}
