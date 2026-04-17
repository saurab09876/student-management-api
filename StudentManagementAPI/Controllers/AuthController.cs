// Controllers/AuthController.cs
using Microsoft.AspNetCore.Mvc;
using StudentManagementAPI.Services;

[ApiController]
[Route("api/[controller]")]
public class AuthController : ControllerBase
{
    private readonly JwtService _jwt;

    public AuthController(JwtService jwt)
    {
        _jwt = jwt;
    }

    [HttpPost("login")]
    public IActionResult Login(string username, string password)
    {
        if (username == "admin" && password == "123")
        {
            var token = _jwt.GenerateToken(username);
            return Ok(new { token });
        }

        return Unauthorized();
    }
}