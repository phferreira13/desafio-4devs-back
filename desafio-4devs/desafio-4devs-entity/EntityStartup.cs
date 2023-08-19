using desafio_4devs_entity.Context;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Data.Common;

namespace desafio_4devs_entity
{
    public static class EntityStartup
    {
        public static IServiceCollection AddEntityConfiguration(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<App4DevsContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
            });           

            return services;
        }
    }
}
