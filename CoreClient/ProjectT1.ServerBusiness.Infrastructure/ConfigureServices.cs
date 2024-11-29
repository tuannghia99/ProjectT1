using Microsoft.Extensions.DependencyInjection;
using ProjectT1.Client.ServerBusiness.Infrastructure.Contracts;
using System;

namespace ProjectT1.Client.ServerBusiness.Infrastructure {
    public static class ConfigureServices {
        /// <summary>
        /// Configures the project x server businesses infrastructure, including DictionaryClient, DictionaryIntegrator (without MappingProfiles)
        /// </summary>
        /// <param name="services">The services.</param>
        /// <param name="lifetime">The lifetime.</param>
        /// <returns>IServiceCollection.</returns>
        public static IServiceCollection ConfigureProjectT1ServerBusinessesInfrastructure(this IServiceCollection services, ServiceLifetime lifetime = ServiceLifetime.Transient) {
            services.Add(new(typeof(IProjectT1ApiClientBase), typeof(ProjectT1Client), lifetime));
            services.Add(new(typeof(IProjectT1Client), typeof(ProjectT1Client), lifetime));
            services.Add(new(typeof(ProjectT1ApiClientBase), typeof(ProjectT1Client), lifetime));
            return services;
        }

        public static IServiceCollection ConfigureProjectT1ServerBusinessesInfrastructure(this IServiceCollection services,
            string connectionString,
            ServiceLifetime lifetime = ServiceLifetime.Transient) {

            Func<IServiceProvider, ProjectT1Client> func = (provider) => {
                var apiCLient = new app.StdCommon.SimpleApiClient(connectionString, TimeSpan.FromMinutes(15));
                return new ProjectT1Client(apiCLient.HttpClient);
            };

            services.Add(new(typeof(IProjectT1ApiClientBase), func, lifetime));
            //services.Add(new(typeof(IProjectT1Client), func, lifetime));
            services.Add(new(typeof(ProjectT1ApiClientBase), func, lifetime));
            return services;
        }
    }
}