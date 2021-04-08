using autoinnovationlabtest.Common.Api;
using System.Threading.Tasks;

namespace autoinnovationlabtest.Common.Services.Brands
{
    /// <summary>
    /// Nombre de la interfaz:IBrandService
    /// Interfaz con los metodos permitidos para interactuar con el api relacionados a la tabla Brands
    /// </summary>
    public interface IBrandService : IUrlBase
    {
        /// <summary>
        /// Firma de metodo para obtener todos los datos de Brands
        /// </summary>
        /// <returns>Objeto de tipo Response</returns>
        Task<Response> GetAll();
    }
}
