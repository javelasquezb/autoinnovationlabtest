using autoinnovationlabtest.Common.Services.Cars;
using Microsoft.AspNetCore.Mvc;

namespace autoinnovationlabtest.Web.Controllers
{
    public class CarsController : Controller
    {
        private readonly ICarService _carServices;

        public CarsController(ICarService carServices)
        {
            _carServices = carServices;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
