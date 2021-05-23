using System.Reflection;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace OnionArchitecture.Application
{
    public static class ApplicationBootstrap
    {
        public static void AddApplication(this IServiceCollection services)
        {
            var assembly = Assembly.GetExecutingAssembly();
            services.AddMediatR(assembly);
        }
    }
}