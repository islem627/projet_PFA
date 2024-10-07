using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using app_back_.Services;
using app_back_.Dtos;

namespace app_back_.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserManagementController : ControllerBase
    {
        private readonly IUserManagementService _userManagementService;

        public UserManagementController(IUserManagementService userManagementService)
        {
            _userManagementService = userManagementService;
        }

        // GET: api/usermanagement
        [HttpGet("adduser")]
        public async Task<IActionResult> GetAllUsers()
        {
            var users = await _userManagementService.GetAllUsersAsync();
            return Ok(users);
        }

        // GET: api/usermanagement/{id}
        [HttpGet("{id}")]
        public async Task<IActionResult> GetUserById(byte id)  // Changed int to byte
        {
            var user = await _userManagementService.GetUserByIdAsync(id);
            if (user == null)
            {
                return NotFound();
            }

            return Ok(user);
        }

        // PUT: api/usermanagement/{id}
        [HttpPut("updateuser/{id}")]
        public async Task<IActionResult> UpdateUser(byte id, [FromBody] UserUpdateDto userUpdateDto)  // Changed int to byte
        {
            var result = await _userManagementService.UpdateUserAsync(id, userUpdateDto);
            if (!result)
            {
                return NotFound();
            }

            return NoContent();
        }

        // DELETE: api/usermanagement/{id}
        [HttpDelete("deleteuser/{id}")]
        public async Task<IActionResult> DeleteUser(byte id)  // Changed int to byte
        {
            var result = await _userManagementService.DeleteUserAsync(id);
            if (!result)
            {
                return NotFound();
            }

            return NoContent();
        }
    }
}
