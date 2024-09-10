using System.ComponentModel.DataAnnotations.Schema;

namespace RestaurantApi.Models
{
    public class Livreur : Compte
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public byte IdLivreur { get; set; }
        public DateTime Horaire { get; set; }
        [MaxLength(20)]
        public string Email { get; set; }
        [MaxLength(20)]
        public string Prenom { get; set; }
        [MaxLength(20)]
        public string Nom { get; set; }
        [MaxLength(8)]
        public string Password { get; set; }
        [MaxLength(20)]
        public string Adresse { get; set; }
        [MaxLength(8)]
        public string NumTel { get; set; }


        public void ChangerCoordonner() { }

        public void ModifierStatus() { }
        public void GetIdLivreur(int IdLivreur) { }
        public ICollection<Commande> Commandes { get; set; }
    }

}
