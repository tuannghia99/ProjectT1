using Microsoft.Extensions.DependencyInjection;
using ProjectT1.DictionaryAPI.Infrastructure.Services;
using System.Reflection;

namespace ProjectT1.DataBusiness.ServiceAPI {
    public static class ConfigureServices {
        public static IServiceCollection ConfigServices(this IServiceCollection services) {
            var asm = Assembly.GetExecutingAssembly();

            // ChucNang

            // DanhMuc
            services.AddTransient<IChucVuService, ChucVuService>();
            services.AddTransient<IPhongBanService, PhongBanService>();
            services.AddTransient<ITrinhDoHocVanService, TrinhDoHocVanService>();

            return services;
        }
    }
}