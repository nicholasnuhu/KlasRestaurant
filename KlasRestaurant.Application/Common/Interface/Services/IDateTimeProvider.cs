namespace KlasRestaurant.Application.Commons.Interface.Services;

public interface IDateTimeProvider
{
    DateTime UtcNow { get; }
}