using System.ComponentModel.DataAnnotations;

namespace app_back_.Dtos
{ 
public class UserDto
{
        [Required]
    public int Id { get; set; }
        [Required]
        [MaxLength(20)]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [MaxLength(8)]
        public string Password { get; set; }
        [Required]
        [MaxLength(20)]
        public string Type { get; set; } // "Client", "Livreur", ou "Restaurant"
}
}
