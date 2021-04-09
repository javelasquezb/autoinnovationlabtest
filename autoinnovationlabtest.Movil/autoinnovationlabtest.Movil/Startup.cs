using autoinnovationlabtest.Movil.DependecyInjection;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace autoinnovationlabtest.Movil
{
    /// <summary>
    /// Nombre de la clase Startup
    /// Clase para iniciar la configuracion de servicio de Dependecy Injection
    /// </summary>
    public static class Startup
    {
        public static IServiceProvider ServiceProvider { get; set; }

        public static IServiceProvider Init()
        {
            var serviceProvider =
                new ServiceCollection()
                    .ConfigureServices()
                    .BuildServiceProvider();
            ServiceProvider = serviceProvider;

            return serviceProvider;
        }
    }
}
