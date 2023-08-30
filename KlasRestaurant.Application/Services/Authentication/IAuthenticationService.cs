using ErrorOr;

namespace KlasRestaurant.Application.Services.Authentication;

    public interface IAuthenticationService
    {
        ErrorOr<AuthenticationServiceResponse> Register(string firstName, string lastName, string email, string password, string confirmPassword);
        ErrorOr<AuthenticationServiceResponse> Login(string email, string password);
    }
