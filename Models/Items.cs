using System.ComponentModel.DataAnnotations.Schema;

namespace RestaurantApi.Models
{
    public class Items
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdMenu { get; set; }
        public string Nom { get; set; }
        public string Description { get; set; }
        public float PrixRepas { get; set; }
        public int IdRepas { get; set; }
        
    }

}
