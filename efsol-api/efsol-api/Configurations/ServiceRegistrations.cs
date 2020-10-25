using efsol_api.Services;
using efsol_api.Services.Abstractions;
using Microsoft.Extensions.DependencyInjection;

namespace efsol_api.Configurations
{
    public static class ServiceRegistrations
    {
        public static IServiceCollection RegisterServices(this IServiceCollection services)
        {
            services.AddTransient<IQuestionaryService, QuestionaryService>();

            return services;
        }
    }
}
