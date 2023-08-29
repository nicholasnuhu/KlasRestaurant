using FoodApplication.Infrastructure.Logger;
using KlasRestaurant.Application.Common.Interface.Logger;
using Microsoft.Extensions.DependencyInjection;

namespace FoodApplication.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            
            services.AddScoped<ILoggerManager, LoggerManager>();
            return services;
        }
    }
}