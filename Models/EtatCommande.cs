using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace app_back_.Models
{
    public class EtatCommande
    {

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public byte IdEtat { get; set; }
        [MaxLength(50)]
        public string Description { get; set; }
        public int CommandeId { get; set; }
        public virtual ICollection<Commande> Commandes { get; set; }



    }
}
