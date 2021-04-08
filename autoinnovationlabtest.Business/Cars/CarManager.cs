using autoinnovationlabtest.Common.Api;
using autoinnovationlabtest.Common.Models;
using autoinnovationlabtest.Data.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace autoinnovationlabtest.Business.Cars
{
    /// <summary>
    /// Nombre de la clase: CarManager
    /// Clase para la implementacion de los metodos para la interaccion con la clase Car
    /// </summary>
    public class CarManager : ICarManager
    {
        //Variable para el manejo de datos de la clase Car
        private readonly ICarRepository _carRepository;

        /// <summary>
        /// Constructor de la clase
        /// </summary>
        /// <param name="carRepository"></param>
        public CarManager(ICarRepository carRepository)
        {
            _carRepository = carRepository;
        }

        /// <summary>
        /// Implementacion del metodo GetAll
        /// </summary>
        /// <returns></returns>
        public async Task<Response> GetAll()
        {
            Response result = new Response();
            try
            {
                var cars = _carRepository.GetAll();
                if(cars.Count() > 0)
                {
                    result.Result = await cars.Select(c => new Car
                    {
                        Id = c.Id,
                        Model = c.Model,
                        Year = c.Year.ToString()
                    }).ToListAsync();
                    result.IsSucced = true;
                }
                else
                {
                    result.Message = "No se conseguieron registros de Carros.";
                }
            }
            catch (Exception ex)
            {

                result.Message = "Ha ocurrido un error intentado consultar todos los datos.";
            }
            return result;
        }

        /// <summary>
        /// Implementacion del metodo GetAll
        /// </summary>
        /// <returns></returns>
        public async Task<Response> GetAllInformation(Car car)
        {
            Response result = new Response();
            try
            {
                var carEntity = await  _carRepository.GetAllInfo(car.Id);
                if (carEntity != null)
                {
                    result.Result = new Car
                    {
                        Id = carEntity.Id,
                        Brand = carEntity.Brand.Name,
                        Model = carEntity.Model,
                        Year = carEntity.Year.ToString()
                    };
                    result.IsSucced = true;
                }
                else
                {
                    result.Message = "No se consiguio el registro de carro indicado.";
                }
            }
            catch (Exception ex)
            {

                result.Message = "Ha ocurrido un error intentado consultar todos los datos.";
            }
            return result;
        }
    }
}
