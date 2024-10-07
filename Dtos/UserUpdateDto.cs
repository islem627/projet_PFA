
using System.ComponentModel.DataAnnotations;


    namespace app_back_.Dtos
{
    public class UserUpdateDto
    {
        [Required]
        [MaxLength(20)]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [MaxLength(8)]
        public string Password { get; set; }
    }

}
