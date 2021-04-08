using autoinnovationlabtest.Common.Api;
using System.Threading.Tasks;

namespace autoinnovationlabtest.Common.Services.Brands
{
    /// <summary>
    /// Nombre de la clase: BrandService
    /// Clase con la implementacion de los metodos permitidos a consultar al api relacionados a la tabla Brands
    /// </summary>
    public class BrandService : IBrandService
    {
        //Variable de url para conexion a api
        private string _urlBase;
        //Variable para ejecutar metodos de api
        private readonly IApiService _apiService;
        public BrandService(IApiService apiService)
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
            string url = this._urlBase + Constants.WS_GETALLBRANDS;
            return await this._apiService.GetAsync(url);
        }
    }
}
