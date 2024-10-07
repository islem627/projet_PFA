using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace app_back_.Models

{
    public class Commande

    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        [Key]
        public int NumCom { get; set; }
        public DateTime DatePreparation { get; set; }
        public DateTime DateEnregistrement { get; set; }
        public DateTime DateSuppression { get; set; }
        public virtual ICollection<Client_Commande> Client_Commandes { get; set; }
        public virtual ICollection<Restaurant_Commande> Restaurant_Commandes { get; set; }
        public virtual ICollection<Constituer> Constituers { get; set; }
        public byte FK_IdEtat { get; set; }
        public virtual EtatCommande EtatCommande { get; set; }
    }
}
