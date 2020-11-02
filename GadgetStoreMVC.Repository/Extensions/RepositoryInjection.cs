using GadgetStoreMVC.Repository.ConcreteRepositories;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace GadgetStoreMVC.Repository.Extensions
{
    public static class RepositoryInjection
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services,
            IConfiguration configuration)
        {
            services.AddScoped<GadgetRepository, GadgetRepository>();
            services.AddScoped<OrderRepository, OrderRepository>();
            return services;
        }
    }
}