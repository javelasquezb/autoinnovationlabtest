using autoinnovationlabtest.Business.Brands;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace autoinnovationlabtest.API.Controllers
{
    [ApiController]
    public class BrandsController : ControllerBase
    {
        private readonly IBrandManager _brandManager;

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
