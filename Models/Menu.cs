using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace app_back_.Models
{
    public class Menu
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public byte IdMenu { get; set; }

        [MaxLength(20)]
        public string Categories { get; set; }

        [MaxLength(20)]
        public string Description { get; set; }

        // Relation avec Menu_Item
        public virtual ICollection<Menu_Item> Menu_Items { get; set; }

        // Relation avec Constituer
        public virtual ICollection<Constituer> Constituers { get; set; }

        // Clé étrangère pour la relation avec Panier
        public byte FK_IdPanier { get; set; } // Clé étrangère pour Panier
        public virtual Panier Panier { get; set; } // Propriété de navigation vers Panier
    }
}
