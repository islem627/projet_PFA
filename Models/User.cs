using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace app_back_.Models
{
    public class User
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public byte? Id { get; set; }

        public DateTime? Horaire { get; set; }

        [MaxLength(20)]
        [EmailAddress]
        public string? Email { get; set; }

        [MaxLength(20)]
        public string? Prenom { get; set; }

        [MaxLength(20)]
        public string? Nom { get; set; }

        [MaxLength(8)]
        public string? Password { get; set; }

        [MaxLength(20)]

        public string? Adresse { get; set; }

        [MaxLength(8)]
        public string? NumTel { get; set; }

        public string Type { get; set; }
        

    }
}
