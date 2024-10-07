using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace app_back_.Models
{
    public class StatusLivraison
    {

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]

        public byte IdStatus { get; set; }
        [MaxLength(100)]
        public string Description { get; set; }
        public virtual ICollection<Livraison> Livraisons { get; set; }

    }

}

