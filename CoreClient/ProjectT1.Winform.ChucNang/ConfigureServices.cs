using app.StdFramework;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using Microsoft.Extensions.DependencyInjection;

namespace ProjectT1.Client.Winform.ChucNang {
    public static class ConfigureServices {
        public static IServiceCollection ConfigureFormsProjectT1ChucNangClient(this IServiceCollection services, ServiceLifetime lifetime = ServiceLifetime.Transient) {
            var asm = System.Reflection.Assembly.GetExecutingAssembly();
            return services
                .AddAllInstanceTypesOfBase(asm, typeof(RibbonForm), lifetime)
                .AddAllInstanceTypesOfBase(asm, typeof(XtraForm), lifetime);
        }
    }
}