using autoinnovationlabtest.Business.Brands;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace autoinnovationlabtest.API.Controllers
{
    /// <summary>
    /// Controlador de Marcas
    /// </summary>
    [ApiController]
    public class BrandsController : ControllerBase
    {
        //Variable para el manejo de datos
        private readonly IBrandManager _brandManager;

        /// <summary>
        /// Consturctor de la clase
        /// </summary>
        /// <param name="brandManager"></param>
        public BrandsController(IBrandManager brandManager)
        {
            _brandManager = brandManager;
        }

        /// <summary>
        /// Metodo para obtener listados de Marcas de carros
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("api/[controller]")]
        public async Task<IActionResult> GetAll() => Ok(await _brandManager.GetAll());
    }
}
