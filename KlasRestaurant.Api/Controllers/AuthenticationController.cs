using ErrorOr;
using KlasRestaurant.Application.Services.Authentication;
using KlasRestaurant.Contracts.Authentications;
using Microsoft.AspNetCore.Mvc;

namespace KlasRestaurant.Api.Controllers;


[Route("auth")]
[ApiController]
public class AuthenticationController : ApiController
{
    private readonly IAuthenticationService _authenticationService;

    public AuthenticationController(IAuthenticationService authenticationService)
    {
        _authenticationService = authenticationService;
    }

    [HttpPost("register")]
    public IActionResult Register(RegisterRequest request)
    {
        ErrorOr<AuthenticationServiceResponse> authResponse = _authenticationService.Register(
            request.FirstName,
            request.LastName,
            request.Email,
            request.Password,
            request.ConfirmPassword);

        return authResponse.Match(
            authResponse => Ok(AuthMatch(authResponse)),
            errors => Problem(errors)
        );

        
    }


    [HttpPost("login")]
    public IActionResult Login(LoginRequest request)
    {
        ErrorOr<AuthenticationServiceResponse> authResponse = _authenticationService.Login(
            request.Email,
            request.Password);
        return authResponse.Match(
            authResponse => Ok(AuthMatch(authResponse)),
            errors => Problem(errors)
        );

    }

    private static AuthenticationResponse AuthMatch(AuthenticationServiceResponse authResponse)
        {
            return new AuthenticationResponse(
                        authResponse.User.Id,
                        authResponse.User.FirstName,
                        authResponse.User.LastName,
                        authResponse.User.Email,
                        authResponse.Token);
        }

}