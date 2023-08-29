using KlasRestaurant.Domain.Entities;

namespace KlasRestaurant.Application.Commons.Interface.Persistence;

    public interface IUserRepository
    {
        void AddUser(User user);
        User? GetUserByEmail(string email);

    }
