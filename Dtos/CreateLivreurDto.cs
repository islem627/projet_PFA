using System.ComponentModel.DataAnnotations;

namespace app_back_.Dtos
{
    public class CreateLivreurDto
    {
        [Required]
        public DateTime Horaire { get; set; }

        [Required]
        [MaxLength(20)]
        [EmailAddress]

        public string Email { get; set; }
        [Required]
        [MaxLength(20)]
        public string Prenom { get; set; }
        [Required]
        [MaxLength(20)]
        public string Nom { get; set; }
        [Required]
        [MaxLength(8)]
        public string Password { get; set; }
        [Required]
        [MaxLength(20)]
        public string Adresse { get; set; }
        [Required]
        [MaxLength(8)]
        public string NumTel { get; set; }

    }
}
