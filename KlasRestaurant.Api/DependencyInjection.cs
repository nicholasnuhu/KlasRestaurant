
using FoodApplication.Api.Commons.Errors;
using Microsoft.AspNetCore.Mvc.Infrastructure;

namespace FoodApplication.Api;

public static class DependencyInjection
{
    public static IServiceCollection AddApi(this IServiceCollection services)
    {
        services.AddControllers();
        // Add the KlasRestaurantProblemDetailsFactory to the DI container to override the default ProblemDetailsFactory
        services.AddSingleton<ProblemDetailsFactory, KlasRestaurantProblemDetailsFactory>();
        return services;
    }
}