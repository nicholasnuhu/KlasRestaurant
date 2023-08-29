using KlasRestaurant.Application.Commons.Interface.Persistence;
using KlasRestaurant.Domain.Entities;

namespace KlasRestaurant.Infrastructure.Persistence;

public class UserRepository : IUserRepository
{
    private static readonly List<User> Users = new();
    public void AddUser(User user)
    {
        Users.Add(user);
    }

    public User? GetUserByEmail(string email)
    {
        return Users.SingleOrDefault(user => user.Email == email);
    }
}