using System.ComponentModel.DataAnnotations.Schema;

namespace RestaurantApi.Models
{
    public class Panier
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdPanier { get; set; }
        public int NbrArticle { get; set; }
        public int IdClient { get; set; }
        public int NumCom { get; set; }
        

        public void Supprimer(int refRepas) { }
        public void Modifier(int refRepas, int qte) { }
        public float CalculerMontant() { return 0; }
        public void Ajouter(int refRepas, int qte) { }
    }

}
