namespace RestaurantApi.Models
{
    public class EtatCommande
    {
        public int IdEtat { get; set; }
        public int NumCom { get; set; }
        public string Description { get; set; }
       
        public ICollection<Commande> Commandes { get; set; }
    }

}
