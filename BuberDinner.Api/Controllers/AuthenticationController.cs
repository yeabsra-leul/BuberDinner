using BuberDinner.Contracts.Authentication;
using Microsoft.AspNetCore.Mvc;

namespace BuberDinner.Api.Controllers;

[ApiController]
[Route("auth")]
public class AuthenticationController :ControllerBase {
    
    [HttpPost("resgister")]
    public IActionResult Register(RegisterRequest request){
        return (request);
    }

    [HttpPost("login")]
    public IActionResult Login(RegisterRequest request){
        return (request);
    }
}
