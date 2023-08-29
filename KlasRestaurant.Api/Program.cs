using NLog;
using FoodApplication.Infrastructure;
using FoodApplication.Application;
using FoodApplication.Api;

var builder = WebApplication.CreateBuilder(args);
LogManager.Setup().LoadConfigurationFromFile(string.Concat(Directory.GetCurrentDirectory(), "/nlog.config"));
{
    builder.Services.AddInfrastructure()
                    .AddApplication()
                    .AddApi();
}


var app = builder.Build();
{
    app.UseHttpsRedirection();

    app.MapControllers();

    app.Run();
}