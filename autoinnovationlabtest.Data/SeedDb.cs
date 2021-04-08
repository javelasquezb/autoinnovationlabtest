using autoinnovationlabtest.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace autoinnovationlabtest.Data
{
    public class SeedDb
    {
        private readonly DataContext _context;

        public SeedDb(DataContext context)
        {
            _context = context;
        }

        public async Task SeedAsync()
        {
            await CreateBrandAsync();
            await CreateCarsAsync();
        }

        private async Task CreateCarsAsync()
        {
            if (!await _context.Cars.AnyAsync())
            {
                var brand = await _context.Brands.Where(b => b.Name == "Kia").SingleOrDefaultAsync();
                var cars = new List<Car>
                {
                    new Car{ BrandId = brand.Id, Model = "Ceed", Year = 2021  },
                    new Car{ BrandId = brand.Id, Model = "Optima", Year = 2021  },
                    new Car{ BrandId = brand.Id, Model = "Picanto", Year = 2021  },
                    new Car{ BrandId = brand.Id, Model = "Rio", Year = 2021  },
                    new Car{ BrandId = brand.Id, Model = "Sorento", Year = 2021  },
                };
                await _context.Cars.AddRangeAsync(cars);
                await _context.SaveChangesAsync();

                brand = await _context.Brands.Where(b => b.Name == "BMW").SingleOrDefaultAsync();
                cars = new List<Car>
                {
                    new Car{ BrandId = brand.Id, Model = "i3", Year = 2021  },
                    new Car{ BrandId = brand.Id, Model = "Serie 1 2020", Year = 2021  },
                    new Car{ BrandId = brand.Id, Model = "Serie 1 2017", Year = 2021  },
                    new Car{ BrandId = brand.Id, Model = "Serie 2 2020. Gran Coupé", Year = 2021  },
                };
                await _context.Cars.AddRangeAsync(cars);
                await _context.SaveChangesAsync();

                brand = await _context.Brands.Where(b => b.Name == "Audi").SingleOrDefaultAsync();
                cars = new List<Car>
                {
                    new Car{ BrandId = brand.Id, Model = "A1", Year = 2021  },
                    new Car{ BrandId = brand.Id, Model = "A3", Year = 2021  },
                    new Car{ BrandId = brand.Id, Model = "A4", Year = 2021  },
                };
                await _context.Cars.AddRangeAsync(cars);
                await _context.SaveChangesAsync();

                brand = await _context.Brands.Where(b => b.Name == "Mazda").SingleOrDefaultAsync();
                cars = new List<Car>
                {
                    new Car{ BrandId = brand.Id, Model = "Mazda2", Year = 2021  },
                    new Car{ BrandId = brand.Id, Model = "Mazda CX-5", Year = 2021  },
                };
                await _context.Cars.AddRangeAsync(cars);
                await _context.SaveChangesAsync();

                brand = await _context.Brands.Where(b => b.Name == "Ferrari").SingleOrDefaultAsync();
                cars = new List<Car>
                {
                    new Car{ BrandId = brand.Id, Model = "California T", Year = 2021  },
                };
                await _context.Cars.AddRangeAsync(cars);
                await _context.SaveChangesAsync();
            }
        }

        private async Task CreateBrandAsync()
        {
            if(!await _context.Brands.AnyAsync())
            {
                var brands = new List<Brand>
                {
                    new Brand{ Name = "Kia"},
                    new Brand{ Name = "BMW"},
                    new Brand{ Name = "Audi"},
                    new Brand{ Name = "Mazda"},
                    new Brand{ Name = "Ferrari"},
                    new Brand{ Name = "Alfa Romeo"}
                };
                await _context.Brands.AddRangeAsync(brands);
                await _context.SaveChangesAsync();
            }
        }


    }
}
