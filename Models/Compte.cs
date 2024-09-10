using System.ComponentModel.DataAnnotations.Schema;

namespace RestaurantApi.Models
{
    public class Compte
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Email { get; set; }
        public string Prenom { get; set; }
        public string Nom { get; set; }
        public string Password { get; set; }
        public string Adresse { get; set; }
        public string NumTel { get; set; }

        public void ChangerCoordonner() { }
    }

}
