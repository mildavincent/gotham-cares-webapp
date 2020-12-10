using GothamCares.DataServices.Contracts;
using GothamCares.DataServices.Impl;
using Microsoft.Extensions.DependencyInjection;

namespace GothamCares.DataServices
{
    public static class ServiceRegistry
    {
        public static IServiceCollection AddDataServices(this IServiceCollection services)
        {
            services.AddScoped<IOutletDataService, OutletDataService>();
            return services;
        }
    }
}
