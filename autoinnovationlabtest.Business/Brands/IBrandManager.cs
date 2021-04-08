using autoinnovationlabtest.Common.Api;
using System.Threading.Tasks;

namespace autoinnovationlabtest.Business.Brands
{
    /// <summary>
    /// Nombre de la interfaz: IBrandManager
    /// Interfaz con los metodos necesarios para el manejo de la base de datos con Brand
    /// </summary>
    public interface IBrandManager
    {
        /// <summary>
        /// Firma del metodo GetAll
        /// Metodo para consultar todos los registros de Brand
        /// </summary>
        /// <returns>Objeto de tipo Response</returns>
        Task<Response> GetAll();
    }
}
