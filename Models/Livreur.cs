using System.ComponentModel.DataAnnotations;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace app_back_.Models
{
    public class Livreur
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public byte IdLivreur { get; set; }

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

        public string Type { get; } = "Livreur"; // Type en lecture seule
        public virtual Livraison Livraison { get; set; } // Relation 1 à 1


        // Méthode pour exécuter un test
        public void TestLivreurType()
        {
            var livreur = new Livreur();
            if (livreur.Type != "Livreur")
            {
                throw new Exception("Le type du livreur n'est pas correct.");
            }
            Console.WriteLine("Le test a réussi : le type est correct.");
        }
    }
}