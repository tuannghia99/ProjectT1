using app.StdCommon;
using DevExpress.LookAndFeel.Design;
using DevExpress.XtraEditors;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using NLog.Extensions.Logging;
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


            var appCode = Configuration.GetValue<string>("AppSettings:AppCode");
            //var jsonString = param.GetType().GetProperty("jsonString")?.GetValue(param).SafeToString();
            //if (jsonString.IsNullOrEmpty()) return null;
            //var jsonObj = JObject.Parse(jsonString);


            //  ProjectX.Client.JsonBusiness.Infrastructure.CommonUtilities.DataFileFolder = Application.StartupPath + "DataFile\\";
            Application.ThreadException += new System.Threading.ThreadExceptionEventHandler(Application_ThreadException);
            AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(CurrentDomain_UnhandledException);
            Application.Run(ServiceProvider.GetRequiredService<FormMain>());
        }

        private static void Application_ThreadException(object sender, System.Threading.ThreadExceptionEventArgs e) {
            HandleException(e.Exception);
        }

        private static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e) {
            if (e.ExceptionObject is Exception ex) {
                HandleException(ex);
            }
        }

        private static void HandleException(Exception ex) {
            if (ex is TimeoutException) {
            }
            else {
                XtraMessageBox.Show("Mạng kết nối không ổn định, hãy thử lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
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
                    services.AddTransient<FormMain>();
                });
        }
    }
}