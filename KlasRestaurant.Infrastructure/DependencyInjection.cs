using KlasRestaurant.Application.Commons.Interface.Authentication;
using KlasRestaurant.Application.Commons.Interface.Persistence;
using KlasRestaurant.Application.Commons.Interface.Services;
using KlasRestaurant.Infrastructure.Authentication;
using KlasRestaurant.Infrastructure.Logger;
using KlasRestaurant.Infrastructure.Persistence;
using KlasRestaurant.Infrastructure.Service;
using KlasRestaurant.Application.Common.Interface.Logger;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace KlasRestaurant.Infrastructure
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