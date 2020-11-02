using GadgetStoreMVC.Data.Context;
using GadgetStoreMVC.Models.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace GadgetStoreMVC.Extensions
{
    public static class IdentityInjection
    {
        public static IServiceCollection AddIdentityRole(this IServiceCollection services,
            IConfiguration configuration)
        {
            services.AddIdentity<User, IdentityRole>(opts =>
                {
                    opts.Password.RequiredLength = 5;
                    opts.Password.RequireNonAlphanumeric = true;
                    opts.Password.RequireLowercase = true;
                    opts.Password.RequireUppercase = true;
                    opts.Password.RequireDigit = true;
                    opts.User.RequireUniqueEmail = true;
                })
                .AddEntityFrameworkStores<IdentityContext>();
            return services;
        }
    }
}