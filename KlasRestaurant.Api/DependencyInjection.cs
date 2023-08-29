
using Microsoft.AspNetCore.Mvc.Infrastructure;

namespace FoodApplication.Api;

public static class DependencyInjection
{
    public static IServiceCollection AddApi(this IServiceCollection services)
    {
        services.AddControllers();
        return services;
    }
}