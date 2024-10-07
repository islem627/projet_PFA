using app_back_.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace app_back_.Models
{
    public class Menu_Item
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key, Column(Order = 0)]
        public byte FK_IdItem { get; set; }

        [ForeignKey("FK_IdItem")]
        public virtual Item Item { get; set; }

        [Key, Column(Order = 1)]
        public byte FK_IdMenu { get; set; }  // Changement ici pour correspondre à la configuration

        [ForeignKey("FK_IdMenu")]
        public virtual Menu Menu { get; set; }
    }
}

