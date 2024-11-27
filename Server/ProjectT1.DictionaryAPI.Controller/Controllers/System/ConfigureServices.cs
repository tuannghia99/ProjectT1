// ***********************************************************************
// Assembly         : ProjectX1.DictionaryAPI.Controller
// Author           : Admin
// Created          : 09-02-2023
//
// Last Modified By : Admin
// Last Modified On : 09-02-2023
// ***********************************************************************
// <copyright file="ConfigureServices.cs" company="ProjectX1.DictionaryAPI.Controller">
//     Copyright (c) . All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using Microsoft.Extensions.DependencyInjection;

namespace ProjectT1.DictionaryAPI.Controller.Controllers {
    /// <summary>
    /// Class DictionaryControllerConfiguration.
    /// </summary>
    public static class DictionaryControllerConfiguration {
        /// <summary>
        /// Configures the dictionary services.
        /// </summary>
        /// <param name="services">The services.</param>
        /// <returns>IServiceCollection.</returns>
        public static IServiceCollection ConfigureDictionaryServices(this IServiceCollection services) {
            // Data context, Mapper and Logger will be configured separately
            //services.AddSingleton<IDistributedCache, MemoryDistributedCache>();
            //services.AddSingleton<ILogger, NLogLoggerImpl>();
            return services;
        }
    }
}
