using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using NLog.Extensions.Logging;
using ProjectT1.CoreClient;
using System.IO;
using System.Text.Json;

namespace ProjectX.CoreClient {
    internal static class Program {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>

        [STAThread]
        static void Main() {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.

            ApplicationConfiguration.Initialize();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var host = CreateHostBuilder().Build();
            ServiceProvider = host.Services;
            Application.Run(ServiceProvider.GetRequiredService<FrmMenu>());
        }
       public static IServiceProvider ServiceProvider { get; private set; }
        public static IConfiguration Configuration { get; private set; }
        static IHostBuilder CreateHostBuilder() {
            Configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json").Build();

            return Host.CreateDefaultBuilder()
                .ConfigureServices((context, services) => {
                    services.AddLogging(config => {
                        config.ClearProviders();
                        config.AddDebug();
                        config.AddNLog();
                        config.AddConsole();
                        //etc
                    });
                    //services.AddTransient<ILogger, NLogLoggerImpl>();
                    //services.AddTransient<ICommonService, CommonService>();
                    services.AddTransient<FrmMenu>();
                });
        }
    }
}