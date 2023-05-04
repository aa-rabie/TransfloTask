using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transflo.Driver.Data
{
    public static class ServiceCollectionExt
    {
        public static IServiceCollection RegisterDataServices(this IServiceCollection services, IConfiguration config)
        {
            services.AddDbContext<DriverDbContext>(options =>
            options.UseSqlite(config.GetConnectionString("DriverApiContext") ?? 
            throw new InvalidOperationException("Connection string 'DriverApiContext' not found.")));

            return services;
        }
    }
}
