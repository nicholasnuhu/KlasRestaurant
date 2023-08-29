using FoodApplication.Contracts.Authentications;
using Microsoft.AspNetCore.Mvc;

namespace FoodApplication.Api.Controllers;


[Route("auth")]
[ApiController]
public class AuthenticationController : ControllerBase
{

    [HttpPost("register")]
    public IActionResult Register(RegisterRequest request)
    {
        return Ok(request);
    }
    

    [HttpPost("login")]
    public IActionResult Login(LoginRequest request)
    {
        return Ok(request);
    }
    
}