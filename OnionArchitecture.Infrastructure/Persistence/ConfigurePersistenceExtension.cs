using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using OnionArchitecture.Application.Interfaces;
using OnionArchitecture.Infrastructure.Context;

namespace OnionArchitecture.Infrastructure.Persistence
{
    public static class ConfigurePersistenceExtension
    {
        public static void AddPersistence(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDbContext>(config =>
            {
                config.UseNpgsql(configuration["ConnectionString"],
                    b => b.MigrationsAssembly(typeof(ApplicationDbContext).Assembly.FullName));
                config.EnableSensitiveDataLogging();
            });

            services.AddScoped<IApplicationDbContext>(provider => provider.GetService<ApplicationDbContext>());
        }
    }
}