using FoodApplication.Domain.Entities;

namespace FoodApplication.Application.Commons.Interface.Authentication
{
    public interface IJwtTokenGenerator
    {
        string GenerateToken(User user);
    }
}