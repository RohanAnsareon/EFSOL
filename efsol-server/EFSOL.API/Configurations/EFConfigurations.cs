using EFSOL.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace EFSOL.API.Configurations
{
    public static class EFConfigurations
    {
        public static IServiceCollection ConfigureEF(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<EFSOLDbContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("EFSOLConnection"));
            });

            return services;
        }
    }
}
