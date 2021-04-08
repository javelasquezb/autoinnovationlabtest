﻿using autoinnovationlabtest.Common.Api;
using autoinnovationlabtest.Common.Models;
using autoinnovationlabtest.Data.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace autoinnovationlabtest.Business.Brands
{
    public class BrandManager : IBrandManager
    {
        private readonly IBrandRepository _brandRepository;

        public BrandManager(IBrandRepository brandRepository)
        {
            _brandRepository = brandRepository;
        }

        public async Task<Response> GetAll()
        {
            Response result = new Response();
            try
            {
                var brands = _brandRepository.GetAll();
                if(brands.Count() > 0)
                {
                    result.Result = await brands.Select(b => new Brand
                    {
                        Id = b.Id,
                        Name = b.Name
                    }).ToListAsync();
                    result.IsSucced = true;
                }
                else
                {
                    result.Message = "No se conseguieron datos de Marcas";
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
