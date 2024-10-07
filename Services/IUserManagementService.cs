using app_back_.Models;
using app_back_.Dtos;
namespace app_back_.Services
{
    public interface IUserManagementService
    {
        Task<IEnumerable<UserDto>> GetAllUsersAsync();
        Task<UserDto> GetUserByIdAsync(byte id);
        Task<bool> UpdateUserAsync(byte id, UserUpdateDto userUpdateDto);
        Task<bool> DeleteUserAsync(byte id);
    }
}