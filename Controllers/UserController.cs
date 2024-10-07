using app_back_.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using app_back_.Services;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace app_back_.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly ApplicationDbContext _authContext;

        public UserController(ApplicationDbContext applicationDbContext)
        {
            _authContext = applicationDbContext;
        }

        // User authentication (Login)
        [HttpPost("authenticate")]
        public async Task<IActionResult> Authenticate([FromBody] User userObj)
        {
            if (userObj == null)
                return BadRequest(new { Message = "Invalid request." });

            // Fetch user based on email
            var user = await _authContext.Users.FirstOrDefaultAsync(x => x.Email == userObj.Email);

            if (user == null)
                return NotFound(new { Message = "User not found!" });

            // Compare hashed password
            if (!PasswordHasher.VerifyPassword(userObj.Password, user.Password))
            {
                return BadRequest(new { Message = "Incorrect password." });
            }

            return Ok(new
            {
                Message = "Login successful!"
            });
        }

        // User registration
        [HttpPost("register")]
        public async Task<IActionResult> RegisterUser([FromBody] User userObj)
        {
            if (userObj == null)
                return BadRequest(new { Message = "Invalid request." });

            // Check if email is already registered
            var existingUser = await _authContext.Users.FirstOrDefaultAsync(x => x.Email == userObj.Email);
            if (existingUser != null)
            {
                return BadRequest(new { Message = "Email is already registered." });
            }

            // Hash the user's password before saving
            userObj.Password = PasswordHasher.HashPassword(userObj.Password);

            await _authContext.Users.AddAsync(userObj);
            await _authContext.SaveChangesAsync();

            return Ok(new
            {
                Message = "User registered successfully!"
            });
        }
    }
}
