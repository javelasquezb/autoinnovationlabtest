using autoinnovationlabtest.Common.Api;
using autoinnovationlabtest.Common.Models;
using System.Threading.Tasks;

namespace autoinnovationlabtest.Common.Services.Cars
{
    /// <summary>
    /// Nombre de la clase: CarService
    /// Clase para implementar los metodos de la interfaz
    /// </summary>
    public class CarService : ICarService
    {
        //Variable de url para conexion a api
        private string _urlBase;
        //Variable para ejecutar metodos de api
        private readonly IApiService _apiService;

        /// <summary>
        /// Contructor de la clase
        /// </summary>
        /// <param name="apiService"></param>
        public CarService(IApiService apiService)
        {
            _apiService = apiService;
        }

        /// <summary>
        /// Propiedad UrlBase
        /// </summary>
        public string UrlBase { set => _urlBase = value; }

        /// <summary>
        /// Implementacion del metodo GetAll
        /// </summary>
        /// <returns>Objeto de tipo Response</returns>
        public async Task<Response> GetAll()
        {
            string url = this._urlBase + Constants.WS_GETALLCARS;
            return await this._apiService.GetAsync(url);
        }

        /// <summary>
        /// Implementacion del metodo GetAllInformation
        /// </summary>
        /// <param name="car"></param>
        /// <returns>Objeto de tipo Response</returns>
        public async Task<Response> GetAllInformation(Car car)
        {
            string url = this._urlBase + Constants.WS_GETALLINFORMATIONCARS;
            return await this._apiService.PostAsync(url,car);
        }
    }
}
