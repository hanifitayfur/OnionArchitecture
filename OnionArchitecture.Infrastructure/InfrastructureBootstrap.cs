using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using OnionArchitecture.Infrastructure.Mapper;
using OnionArchitecture.Infrastructure.Persistence;

namespace OnionArchitecture.Infrastructure
{
    public static class InfrastructureBootstrap
    {
        public static void AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddPersistence(configuration);
            services.ConfigureMapping();
        }
    }
}