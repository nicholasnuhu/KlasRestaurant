using FoodApplication.Domain.Entities;

namespace FoodApplication.Application.Services.Authentication;

public record AuthenticationServiceResponse(
    User User,
    string Token);