using GadgetStoreMVC.Services.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace GadgetStoreMVC.Services.Extensions
{
    public static class ServiceInjection
    {
        public static IServiceCollection AddServices(this IServiceCollection services,
            IConfiguration configuration)
        {
            services.AddScoped<GadgetServices, GadgetServices>();
            services.AddScoped<OrderServices, OrderServices>();
            return services;
        }
    }
}