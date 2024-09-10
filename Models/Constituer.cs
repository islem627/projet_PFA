using System.ComponentModel.DataAnnotations.Schema;

namespace RestaurantApi.Models
{
    public class Constituer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int Qte { get; set; }
        
    }

}
