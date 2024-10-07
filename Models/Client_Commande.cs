using app_back_.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace app_back_.Models
{
    public class Client_Commande
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key, Column(Order = 0)]
        public byte FK_IdClient { get; set; }
        public virtual Client Client { get; set; }
        [Key, Column(Order = 1)]
        public int FK_NumCom { get; set; }
        public virtual Commande Commande { get; set; }
    }
}
