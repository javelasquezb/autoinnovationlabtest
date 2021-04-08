﻿using autoinnovationlabtest.Common.Models;
using autoinnovationlabtest.Common.Services.Cars;
using autoinnovationlabtest.Web.Helpers;
using autoinnovationlabtest.Web.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace autoinnovationlabtest.Web.Controllers
{
    /// <summary>
    /// Nombre del controlador: CarsController
    /// Controlador para el manejo de todas la paginas o consultas relacionadas con Cars
    /// </summary>
    public class CarsController : Controller
    {
        //Variable para interacturar con el servicio
        private readonly ICarService _carServices;
        //Variable para construir combox
        private readonly IComboHelper _comboHelper;

        /// <summary>
        /// Constructor de la clase
        /// </summary>
        /// <param name="configuration"></param>
        /// <param name="carServices"></param>
        /// <param name="comboHelper"></param>
        public CarsController(IConfiguration configuration,ICarService carServices,IComboHelper comboHelper)
        {
            _carServices = carServices;
            _carServices.UrlBase = configuration.GetValue<string>("UrlApi");
            _comboHelper = comboHelper;
        }

        /// <summary>
        /// Metodo para retornar la pagina index
        /// </summary>
        /// <returns></returns>
        public async Task<IActionResult> Index()
        {
            var model = new CarViewModel
            {
                Brands = await _comboHelper.GetComboBrands()
            };
            return View(model);
        }

        /// <summary>
        /// Metodo para consultar por server side los registros del data table
        /// </summary>
        /// <returns></returns>
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
                var searchBrand = Request.Form["columns[3][search][value]"].FirstOrDefault();

                //Paging Size (10, 20, 50,100)  
                int pageSize = length != null ? Convert.ToInt32(length) : 0;
                int skip = start != null ? Convert.ToInt32(start) : 0;

                int recordsTotal = 0;
                List<CarViewModel> data = new List<CarViewModel>();
                var response = await _carServices.GetAll();
                if (response.IsSucced)
                {
                    var cars = JsonConvert.DeserializeObject<List<Car>>(response.Result.ToString());
                    var query = cars.AsQueryable();
                    if (!string.IsNullOrEmpty(searchBrand))
                    {
                        query = query.Where(c => c.Brand == searchBrand);
                    }

                    if (!string.IsNullOrEmpty(searchValue))
                    {
                        query = query.Where(c => c.Model.ToLower().Contains(searchValue.ToLower()) || c.Brand.ToLower().Contains(searchValue.ToLower()));
                    }
                    recordsTotal = query.Count();
                    data = query
                        .OrderBy(c => c.Model)
                        .Skip(skip)
                        .Take(pageSize)
                        .Select(c => new CarViewModel
                        {
                            Id = c.Id,
                            Model = c.Model,
                            Year = c.Year,
                            Brand = c.Brand
                        })
                        .ToList();
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
