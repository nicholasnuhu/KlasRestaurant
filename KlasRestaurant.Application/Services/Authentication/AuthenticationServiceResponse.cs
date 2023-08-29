using KlasRestaurant.Domain.Entities;

namespace KlasRestaurant.Application.Services.Authentication;

public record AuthenticationServiceResponse(
    User User,
    string Token);