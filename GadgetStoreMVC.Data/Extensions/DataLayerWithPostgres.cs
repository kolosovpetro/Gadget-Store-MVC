using System;
using GadgetStoreMVC.Auxiliaries.Auxiliaries;
using GadgetStoreMVC.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace GadgetStoreMVC.Data.Extensions
{
    public static class DataLayerWithPostgreSql
    {
        public static IServiceCollection AddDataLayerWithPostgreSql(this IServiceCollection services,
            IConfiguration configuration)
        {
            var environmentConnectionString = Environment.GetEnvironmentVariable("DATABASE_URL");

            services.AddDbContext<PostgresContext>(options =>
                options.UseNpgsql(
                    StringParser.Convert(environmentConnectionString) ??
                    configuration.GetConnectionString("LOCAL_POSTGRES_CONNECTION_STRING")));

            services.AddTransient<DbContext, PostgresContext>();
            return services;
        }
    }
}