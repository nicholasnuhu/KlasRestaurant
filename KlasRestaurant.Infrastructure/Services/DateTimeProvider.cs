using FoodApplication.Application.Commons.Interface.Services;

namespace FoodApplication.Infrastructure.Service;

public class DateTimeProvider : IDateTimeProvider
{
    public DateTime UtcNow => DateTime.UtcNow;
}