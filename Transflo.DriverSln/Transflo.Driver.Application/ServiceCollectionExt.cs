using Microsoft.Extensions.DependencyInjection;
using Transflo.Driver.Application.Interfaces;
using Transflo.Driver.Application.Services;

namespace Transflo.Driver.Application
{
    public static class ServiceCollectionExt
    {
        public static IServiceCollection RegisterApplicationServices(this IServiceCollection services)
        {
            services.AddScoped<IDriverService, DriverService>();
            services.AddScoped<IAlphabetizerService, AlphabetizerService>();
            return services;
        }
    }
}
