using AutoMapper;
using EFSOL.Application.Models;
using EFSOL.Infrastructure.Entities;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace EFSOL.API.Configurations
{
    public static class AutoMapperConfigurations
    {
        public static IServiceCollection ConfigureAutoMapper(this IServiceCollection services)
        {
            services.AddAutoMapper(new Type[] { typeof(Startup), typeof(QuestionModel), typeof(Question) });

            return services;
        }
    }
}
