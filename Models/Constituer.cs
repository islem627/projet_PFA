using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace app_back_.Models
{
    public class Constituer
    {

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key, Column(Order = 0)]
        public int FK_NumCom { get; set; }
        public virtual Commande Commande { get; set; }
        [Key, Column(Order = 1)]
        public byte IdMenu { get; set; }
        public virtual Menu Menu { get; set; }
        public int Qte { get; set; }
       


    }

}
