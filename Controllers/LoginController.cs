using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using app_back_.Services;
using app_back_.Models;

namespace app_back_.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LoginController : ControllerBase
    {
        private readonly ILoginService _loginService;
        private readonly ILogger<LoginController> _logger;

        public LoginController(ILoginService loginService, ILogger<LoginController> logger)
        {
            _loginService = loginService;
            _logger = logger;
        }

        [HttpPost]
        public IActionResult Login([FromBody] Login loginModel)
        {
            if (ModelState.IsValid)
            {
                _logger.LogInformation("Login attempt for user with email: {Email}", loginModel.Email);

                var result = _loginService.Login(loginModel.Email, loginModel.Password);
                if (result)
                {
                    _logger.LogInformation("Login successful for user: {Email}", loginModel.Email);
                    return Ok(new { message = "Login successful" });
                }
                else
                {
                    _logger.LogWarning("Login failed for user: {Email}", loginModel.Email);
                    return Unauthorized(new { message = "Invalid email or password" });
                }
            }

            _logger.LogWarning("Invalid login attempt with invalid model state.");
            return BadRequest(ModelState);
        }
    }
}
