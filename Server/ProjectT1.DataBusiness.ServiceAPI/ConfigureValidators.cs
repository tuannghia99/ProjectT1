using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using ProjectT1.DictionaryAPI.Infrastructure.DTOs;
using ProjectT1.DictionaryAPI.Infrastructure.Services;
using System.Reflection;

namespace ProjectT1.DataBusiness.ServiceAPI {
    public static class ConfigureValidators {
        public static IServiceCollection ConfigureM8Validators(this IServiceCollection services) {
            var asm = Assembly.GetExecutingAssembly();

            // ChucNang

            // DanhMuc
            services.AddTransient<IValidator<LinhVucDTO>, BaseValidator<LinhVucDTO>>();

            return services;
        }
    }
}
