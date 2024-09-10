using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class CompteController : ControllerBase
{
    private readonly AuthService _authService;

    public CompteController(AuthService authService)
    {
        _authService = authService;
    }

    [HttpPost("login")]
    public IActionResult Login([FromBody] LoginModel model)
    {
        // Authenticate the user (this is just an example, replace with your actual logic)
        var user = AuthenticateUser(model);

        if (user != null)
        {
            // Generate JWT token
            var token = _authService.GenerateToken(user);
            return Ok(new { Token = token });
        }

        return Unauthorized();
    }

    private Compte AuthenticateUser(LoginModel model)
    {
        // Implement your user authentication logic here
        // This is just a placeholder for demonstration purposes
        if (model.Email == "user@example.com" && model.Password == "password")
        {
            return new Compte { Id = 1, Email = model.Email, Password = model.Password };
        }

        return null;
    }
}

public class LoginModel
{
    public string Email { get; set; }
    public string Password { get; set; }
}

public class Compte
{
    public int Id { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
}
