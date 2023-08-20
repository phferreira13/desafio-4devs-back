
using desafio_4devs_domain.Interfaces.Repostirories;
using desafio_4devs_entity.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace desafio_4devs_entity.Ioc
{
    public static class RepositoryStartup
    {
        public static IServiceCollection AddRepositoryConfiguration(this IServiceCollection services)
        {
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IOrganizationRepository, OrganizationRepository>();

            return services;
        }
    }
}
