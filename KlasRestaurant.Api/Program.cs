using NLog;
using FoodApplication.Infrastructure;
using FoodApplication.Application;
using FoodApplication.Api;

var builder = WebApplication.CreateBuilder(args);
LogManager.Setup().LoadConfigurationFromFile(string.Concat(Directory.GetCurrentDirectory(), "/nlog.config"));
{
    builder.Services.AddInfrastructure(builder.Configuration)
                    .AddApplication()
                    .AddApi();
}


var app = builder.Build();
{
    app.UseExceptionHandler("/error");

    app.UseHttpsRedirection();

    app.MapControllers();

    app.Run();
}