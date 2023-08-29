namespace FoodApplication.Application.Services.Authentication;

    public interface IAuthenticationService
    {
        AuthenticationServiceResponse Register(string firstName, string lastName, string email, string password, string confirmPassword);
        AuthenticationServiceResponse Login(string email, string password);
    }
