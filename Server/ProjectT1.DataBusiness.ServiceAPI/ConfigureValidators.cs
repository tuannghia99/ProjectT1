using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using ProjectT1.DictionaryAPI.Infrastructure.DTOs;
using ProjectT1.DictionaryAPI.Infrastructure.Services;
using System.Reflection;

namespace ProjectT1.DataBusiness.ServiceAPI {
    public static class ConfigureValidators {
        public static IServiceCollection ConfigValidators(this IServiceCollection services) {
            var asm = Assembly.GetExecutingAssembly();

            // ChucNang
            services.AddTransient<IValidator<KhenThuongDTO>, BaseValidator<KhenThuongDTO>>();
            services.AddTransient<IValidator<KyLuatDTO>, BaseValidator<KyLuatDTO>>();
            services.AddTransient<IValidator<NhanVienDTO>, BaseValidator<NhanVienDTO>>();

            // DanhMuc
            services.AddTransient<IValidator<ChucVuDTO>, BaseValidator<ChucVuDTO>>();
            services.AddTransient<IValidator<PhongBanDTO>, BaseValidator<PhongBanDTO>>();
            services.AddTransient<IValidator<TrinhDoHocVanDTO>, BaseValidator<TrinhDoHocVanDTO>>();

            return services;
        }
    }
}