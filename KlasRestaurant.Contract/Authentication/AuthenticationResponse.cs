namespace FoodApplication.Contracts.Authentications;

public record AuthenticationResponse(
    Guid Id,
    string FirstName,
    string LastName,
    string Email,
    string Token);
