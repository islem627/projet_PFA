using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace app_back_.Models
{
    public class Livraison
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public byte IdLivraison { get; set; }

        public float TransactionSpec { get; set; }
        public DateTime DateEnvoi { get; set; }
        public DateTime DateLivraison { get; set; }
        public DateTime DateArrivee { get; set; }

        public byte FK_IdPanier { get; set; } // Clé étrangère pour Panier
        public virtual Panier Panier { get; set; }

        public byte FK_IdStatus { get; set; }
        public virtual StatusLivraison StatusLivraison { get; set; }
        public byte FK_IdLivreur { get; set; } // Clé étrangère pour Livreur
        public virtual Livreur Livreur { get; set; } // Propriété de navigation vers Livreur

    }
}