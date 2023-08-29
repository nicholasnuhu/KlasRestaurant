namespace KlasRestaurant.Contracts.Authentications;

public record LoginRequest(
    string Email,
    string Password);
