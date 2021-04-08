using autoinnovationlabtest.Common.Models;
using autoinnovationlabtest.Common.Services.Cars;
using autoinnovationlabtest.Web.Helpers;
using autoinnovationlabtest.Web.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace autoinnovationlabtest.Web.Controllers
{
    public class CarsController : Controller
    {
        private readonly ICarService _carServices;
        private readonly IComboHelper _comboHelper;

        public CarsController(IConfiguration configuration, ICarService carServices,IComboHelper comboHelper)
        {
            _carServices = carServices;
            _carServices.UrlBase = configuration.GetValue<string>("UrlApi");
            _comboHelper = comboHelper;
        }
        public async Task<IActionResult> Index()
        {
            var model = new CarViewModel
            {
                Brands = await _comboHelper.GetComboBrands()
            };
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> GetCars()
        {
            try
            {
                var draw = HttpContext.Request.Form["draw"].FirstOrDefault();

                // Skip number of Rows count  
                var start = Request.Form["start"].FirstOrDefault();

                // Paging Length 10,20  
                var length = Request.Form["length"].FirstOrDefault();

                // Sort Column Name  
                var sortColumn = Request.Form["columns[" + Request.Form["order[0][column]"].FirstOrDefault() + "][name]"].FirstOrDefault();

                // Sort Column Direction (asc, desc)  
                var sortColumnDirection = Request.Form["order[0][dir]"].FirstOrDefault();

                // Search Value from (Search box)  
                var searchValue = Request.Form["search[value]"].FirstOrDefault();

                //Search value of brand
                var searchBrand = Request.Form["columns[1][search][value]"].FirstOrDefault();

                //Paging Size (10, 20, 50,100)  
                int pageSize = length != null ? Convert.ToInt32(length) : 0;
                int skip = start != null ? Convert.ToInt32(start) : 0;

                int recordsTotal = 0;
                List<CarViewModel> data = new List<CarViewModel>();
                var response = await _carServices.GetAll();
                if(response.IsSucced)
                {
                    var cars = JsonConvert.DeserializeObject<List<Car>>(response.Result.ToString());
                    var query = cars.AsQueryable();
                    if(!string.IsNullOrEmpty(searchBrand))
                    {
                        query = query.Where(c => c.Brand == searchBrand);
                    }

                    if (!string.IsNullOrEmpty(searchValue))
                    {
                        query = query.Where(c => c.Model.Contains(searchValue) || c.Brand.Contains(searchValue));
                    }
                    data = await query
                        .OrderBy(c => c.Model)
                        .Skip(skip)
                        .Take(pageSize)
                        .Select(c => new CarViewModel
                            {
                                Id = c.Id,
                                Model = c.Model,
                                Year = c.Year
                            })
                        .ToListAsync();
                }

                //Returning Json Data  
                return Json(new
                {
                    draw = draw,
                    recordsFiltered = recordsTotal,
                    recordsTotal = recordsTotal,
                    data = data
                });
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
