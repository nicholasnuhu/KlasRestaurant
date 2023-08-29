using FoodApplication.Domain.Entities;

namespace FoodApplication.Application.Commons.Interface.Persistence;

    public interface IUserRepository
    {
        void AddUser(User user);
        User? GetUserByEmail(string email);

    }
