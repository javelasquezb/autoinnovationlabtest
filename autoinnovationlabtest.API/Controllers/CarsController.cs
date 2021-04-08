using autoinnovationlabtest.Business.Cars;
using autoinnovationlabtest.Common.Models;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace autoinnovationlabtest.API.Controllers
{
    /// <summary>
    /// Nombre del Controlador: CarsController
    /// </summary>
    [ApiController]
    public class CarsController : ControllerBase
    {
        //Variable para el manejo de datos de car
        private readonly ICarManager _carManager;

        /// <summary>
        /// Constructor de la clase
        /// </summary>
        /// <param name="carManager"></param>
        public CarsController(ICarManager carManager)
        {
            _carManager = carManager;
        }

        /// <summary>
        /// Metodo del api para obtener listado de carros.
        /// </summary>
        /// <returns>Retorna un objeto de tipo IActionResult</returns>
        [HttpGet]
        [Route("api/[controller]")]
        public async Task<IActionResult> GetAll() => Ok(await _carManager.GetAll());

        /// <summary>
        /// Metodo para consultar toda la informacion de un  carro
        /// </summary>
        /// <param name="car">Objeto de la clase Common.Models.Car</param>
        /// <returns>Retorna un objeto de tipo IActionResult</returns>
        [HttpPost]
        [Route("api/[controller]/getallinformation")]
        public async Task<IActionResult> GetAllInformation(Car car) => Ok(await _carManager.GetAllInformation(car));
    }
}
