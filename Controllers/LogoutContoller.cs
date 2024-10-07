using Microsoft.AspNetCore.Mvc;
using app_back_.Services;
using app_back_.Models;

namespace app_back_.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LogoutController : ControllerBase
    {
        private readonly ILogoutService _logoutService;

        public LogoutController(ILogoutService logoutService)
        {
            _logoutService = logoutService;
        }

        [HttpPost]
        public IActionResult Logout([FromBody] Logout logoutModel)
        {
            if (ModelState.IsValid)
            {
                var result = _logoutService.Logout(logoutModel.Email);
                if (result)
                {
                    return Ok(new { message = "Logout successful" });
                }
                else
                {
                    return BadRequest(new { message = "Logout failed" });
                }
            }

            return BadRequest(ModelState);
        }
    }
}
