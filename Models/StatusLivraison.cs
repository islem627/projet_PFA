using System.ComponentModel.DataAnnotations.Schema;

namespace RestaurantApi.Models
{
    public class StatusLivraison
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdLivraison { get; set; }
        public int IdStatus { get; set; }
        
        public string Description { get; set; }
        
        public ICollection<Commande> Commandes { get; set; }
    }

}
