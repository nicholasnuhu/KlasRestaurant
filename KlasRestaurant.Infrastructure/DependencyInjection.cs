using FoodApplication.Application.Commons.Interface.Authentication;
using FoodApplication.Application.Commons.Interface.Persistence;
using FoodApplication.Application.Commons.Interface.Services;
using FoodApplication.Infrastructure.Authentication;
using FoodApplication.Infrastructure.Logger;
using FoodApplication.Infrastructure.Persistence;
using FoodApplication.Infrastructure.Service;
using KlasRestaurant.Application.Common.Interface.Logger;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace FoodApplication.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, ConfigurationManager configuration)
        {
            services.AddScoped<IUserRepository, UserRepository>();
            services.Configure<JwtSettings>(configuration.GetSection(JwtSettings.sectionName));
            services.AddSingleton<IDateTimeProvider, DateTimeProvider>();
            services.AddSingleton<IJwtTokenGenerator, JwtTokenGenerator>();
            services.AddScoped<ILoggerManager, LoggerManager>();
            return services;
        }
    }
}