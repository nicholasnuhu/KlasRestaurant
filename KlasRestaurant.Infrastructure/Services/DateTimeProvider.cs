using KlasRestaurant.Application.Commons.Interface.Services;

namespace KlasRestaurant.Infrastructure.Service;

public class DateTimeProvider : IDateTimeProvider
{
    public DateTime UtcNow => DateTime.UtcNow;
}