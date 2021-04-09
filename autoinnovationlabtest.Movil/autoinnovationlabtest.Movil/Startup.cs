using autoinnovationlabtest.Movil.DependecyInjection;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace autoinnovationlabtest.Movil
{
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
