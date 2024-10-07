using app_back_.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace app_back_.Models
{
    public class Item
    {

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public byte IdItem { get; set; }
        [MaxLength(50)]
        public string Nom { get; set; }
        [MaxLength(50)]
        public string Description { get; set; }
        public float PrixRepas { get; set; }
        public int IdRepas { get; set; }
        public virtual ICollection<Menu_Item> Menu_Items { get; set; }


    }

}
