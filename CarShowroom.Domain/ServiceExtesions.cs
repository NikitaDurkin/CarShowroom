using CarShowroom.Domain.Interfaces;
using CarShowroom.Domain.Services;
using Microsoft.Extensions.DependencyInjection;

namespace CarShowroom.Domain
{
    public static class ServiceExtesions
    {
        public static IServiceCollection AddDomain(this IServiceCollection services)
        {
            services.AddScoped<ICarService, CarService>();
            services.AddScoped<IClientService, ClientService>();
            services.AddScoped<IOrderService, OrderService>();
            return services;
        }
    }
}