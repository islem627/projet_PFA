using System.ComponentModel.DataAnnotations.Schema;

namespace RestaurantApi.Models
{
    public class Menu
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdMenu { get; set; }
        public string Categories { get; set; }
        public string Description { get; set; }
        public int IdRestaurant { get; set; }
    }

}
