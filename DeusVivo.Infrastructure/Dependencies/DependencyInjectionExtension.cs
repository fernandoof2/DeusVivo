using DeusVivo.Domain.Core.Interfaces.Repositories;
using DeusVivo.Domain.Core.Interfaces.Services;
using DeusVivo.Domain.Services;
using DeusVivo.Infrastructure.Data;
using DeusVivo.Infrastructure.Data.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace DeusVivo.Infrastructure.Dependencies
{
    public static class DependencyInjectionExtension
    {
        public static IServiceCollection AddDependencies(IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<SqlContext>(options =>
                options.UseMySql(configuration.GetConnectionString("MySqlConnectionString"),
                new MySqlServerVersion(new Version(8, 0, 15)))
            );

            TransientServices(ref services);
            Repositories(ref services);

            return services;
        }


        private static IServiceCollection TransientServices(ref IServiceCollection services)
        {
            services.AddTransient<IServiceCargo, ServiceCargo>();

            return services;
        }

        private static IServiceCollection Repositories(ref IServiceCollection services)
        {
            services.AddScoped<IRepositoryCargo, RepositoryCargo>();

            return services;
        }
    }
}
