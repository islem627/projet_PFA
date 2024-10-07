using System.ComponentModel.DataAnnotations;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace app_back_.Models
{
    public class Restaurant
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public byte IdRestaurant { get; set; }

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

        public string Type { get; } = "livreur"; // Type en lecture seule
        public virtual ICollection<Restaurant_Commande> Restaurant_Commandes { get; set; }


        // Méthode pour exécuter un test
        public void TestRestaurantType()
        {
            var restaurant = new Restaurant();
            if (restaurant.Type != "livreur")
            {
                throw new Exception("Le type du restaurant n'est pas correct.");
            }
            Console.WriteLine("Le test a réussi : le type est correct.");
        }
        
    }
}
