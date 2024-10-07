using System.ComponentModel.DataAnnotations;

namespace app_back_.Dtos
{
    public class CreateRestaurantDto
    {
        [Required]
        public DateTime Horaire { get; set; }

        [MaxLength(20)]
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [MaxLength(20)]
        [Required]
        public string Prenom { get; set; }

        [MaxLength(20)]
        [Required]
        public string Nom { get; set; }

        [MaxLength(8)]
        [Required]
        public string Password { get; set; }

        [MaxLength(20)]
        [Required]
        public string Adresse { get; set; }

        [MaxLength(8)]
        [Required]
        public string NumTel { get; set; }
    }
}
