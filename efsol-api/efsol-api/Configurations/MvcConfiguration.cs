using Microsoft.Extensions.DependencyInjection;
using System.Text.Json.Serialization;

namespace efsol_api.Configurations
{
    public static class MvcConfiguration
    {
        public static IMvcBuilder ConfigureMvc(this IServiceCollection services)
        {
            return services.AddControllers()
            .AddJsonOptions(options =>
            {
                options.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter());
                options.JsonSerializerOptions.IgnoreNullValues = true;
            });
        }
    }
}
