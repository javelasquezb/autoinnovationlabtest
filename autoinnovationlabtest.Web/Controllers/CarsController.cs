using autoinnovationlabtest.Common.Services.Cars;
using Microsoft.AspNetCore.Mvc;

namespace autoinnovationlabtest.Web.Controllers
{
    public class CarsController : Controller
    {
        private readonly ICarServices _carServices;

        public CarsController(ICarServices carServices)
        {
            _carServices = carServices;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
