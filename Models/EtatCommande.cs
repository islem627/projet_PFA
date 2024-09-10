using System.ComponentModel.DataAnnotations.Schema;

namespace RestaurantApi.Models
{
    public class EtatCommande
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdEtat { get; set; }
        public int NumCom { get; set; }
        public string Description { get; set; }
       
        public ICollection<Commande> Commandes { get; set; }
    }

}
