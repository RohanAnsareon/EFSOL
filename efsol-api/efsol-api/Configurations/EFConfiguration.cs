using efsol_api.Data;
using Microsoft.EntityFrameworkCore;

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace efsol_api.Configurations
{
    public static class EFConfiguration
    {
        public static IServiceCollection ConfigureEF(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<EFSOLDbContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("EFSOLConnection")).UseLazyLoadingProxies();
            });

            return services;
        }
    }
}
