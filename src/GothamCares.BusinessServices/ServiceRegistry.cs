using GothamCares.BusinessServices.Contracts;
using GothamCares.BusinessServices.Impl;
using Microsoft.Extensions.DependencyInjection;

namespace GothamCares.BusinessServices
{
    public static class ServiceRegistry
    {
        public static IServiceCollection AddBusinessServices(this IServiceCollection services)
        {
            services.AddScoped<IOutletService, OutletService>();
            return services;
        }
    }
}
