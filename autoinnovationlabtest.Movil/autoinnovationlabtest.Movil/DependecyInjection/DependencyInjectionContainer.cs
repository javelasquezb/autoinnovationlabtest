using autoinnovationlabtest.Common.Services;
using autoinnovationlabtest.Common.Services.Cars;
using autoinnovationlabtest.Movil.ViewModels;
using Microsoft.Extensions.DependencyInjection;

namespace autoinnovationlabtest.Movil.DependecyInjection
{
    /// <summary>
    /// Nombre de la clase: DependencyInjectionContainer
    /// Clase extension de Service Collection para configurar los servicios del api con Dependecy Injection
    /// </summary>
    public static class DependencyInjectionContainer
    {
        /// <summary>
        /// Metodo para realizar la configuracion de los servicios y ViewModels a utilizar 
        /// </summary>
        /// <param name="services">El objeto de IServiceCollection</param>
        /// <returns>Objeto de tipo IServiceCollection</returns>
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
