using autoinnovationlabtest.Common.Services;
using autoinnovationlabtest.Common.Services.Cars;
using autoinnovationlabtest.Movil.ViewModels;
using Microsoft.Extensions.DependencyInjection;

namespace autoinnovationlabtest.Movil.DependecyInjection
{
    public static class DependencyInjectionContainer
    {
        public static IServiceCollection ConfigureServices(this IServiceCollection services)
        {
            services.AddScoped<IApiService,ApiService>();
            services.AddScoped<ICarService,CarService>();
            services.AddTransient<CarsViewModel>();
            services.AddTransient<CarViewModel>();
            return services;
        }
    }
}
