using app.StdFramework;
using app.StdFramework.Reports;
using Microsoft.Extensions.DependencyInjection;

namespace ProjectY.Report.Infrastructure {
    public static class ControllerConfiguration {
        public static IServiceCollection ConfigureReportInfrastructure(this IServiceCollection services, ServiceLifetime lifetime = ServiceLifetime.Transient) {
            return services.AddAllInstanceTypesOfBase(System.Reflection.Assembly.GetExecutingAssembly(), typeof(IPrintParameter), lifetime);
        }
    }
}