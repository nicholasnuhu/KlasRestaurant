using FoodApplication.Application.Services.Authentication;
using FoodApplication.Contracts.Authentications;
using Microsoft.AspNetCore.Mvc;

namespace FoodApplication.Api.Controllers;


[Route("auth")]
[ApiController]
public class AuthenticationController : ControllerBase
{
    private readonly IAuthenticationService _authenticationService;

    public AuthenticationController(IAuthenticationService authenticationService)
    {
        _authenticationService = authenticationService;
    }

    [HttpPost("register")]
    public IActionResult Register(RegisterRequest request)
    {
        var authResponse = _authenticationService.Register(
            request.FirstName,
            request.LastName,
            request.Email,
            request.Password,
            request.ConfirmPassword);
        
        var response = new AuthenticationResponse(
            authResponse.User.Id,
            authResponse.User.FirstName,
            authResponse.User.LastName,
            authResponse.User.Email,
            authResponse.Token);

        return Ok(response);
    }
    

    [HttpPost("login")]
    public IActionResult Login(LoginRequest request)
    {
        var authResponse = _authenticationService.Login(
            request.Email,
            request.Password);
        
        var response = new AuthenticationResponse(
            authResponse.User.Id,
            authResponse.User.FirstName,
            authResponse.User.LastName,
            authResponse.User.Email,
            authResponse.Token);

        return Ok(response);
    }
    
}