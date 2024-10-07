using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace app_back_.Models
{
    public class Client
    {

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public byte IdClient { get; set; }

        public DateTime Horaire { get; set; }

        [MaxLength(20)]
        [EmailAddress]
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

        public string Type { get; } = "client"; // Type en lecture seule

        public virtual ICollection<Client_Commande> Client_Commandes { get; set; }
        // Méthode pour exécuter un test
        public void TestClientType()
        {
            // Utilisez l'instance actuelle pour vérifier le type
            if (Type != "client")
            {
                throw new Exception("Le type du client n'est pas correct.");
            }
            Console.WriteLine("Le test a réussi : le type est correct.");
        }
    }
}



    

