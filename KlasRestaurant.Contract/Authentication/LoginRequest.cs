namespace FoodApplication.Contracts.Authentications;

public record LoginRequest(
    string Email,
    string Password);
