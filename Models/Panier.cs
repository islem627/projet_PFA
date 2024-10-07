using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace app_back_.Models
{
    public class Panier
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public byte IdPanier { get; set; }

        public int NbrArticle { get; set; }

        public virtual ICollection<Livraison> Livraisons { get; set; }
        public virtual ICollection<Menu> Menus { get; set; } // Relation one-to-many avec Menu
    }
}
