using Microsoft.Extensions.DependencyInjection;
using ProjectT1.DictionaryAPI.Infrastructure.Services;
using System.Reflection;

namespace ProjectT1.DataBusiness.ServiceAPI {
    public static class ConfigureServices {
        public static IServiceCollection ConfigureM8Services(this IServiceCollection services) {
            var asm = Assembly.GetExecutingAssembly();

            // ChucNang

            // DanhMuc
            services.AddTransient<ILinhVucService, LinhVucService>();

            return services;
        }
    }
}
