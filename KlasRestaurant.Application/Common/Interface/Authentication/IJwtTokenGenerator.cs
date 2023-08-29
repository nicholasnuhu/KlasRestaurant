using KlasRestaurant.Domain.Entities;

namespace KlasRestaurant.Application.Commons.Interface.Authentication
{
    public interface IJwtTokenGenerator
    {
        string GenerateToken(User user);
    }
}