namespace RestaurantApi.Models
{
    public class StatusLivraison
    {
        public int IdStatus { get; set; }
        public int IdLivraison { get; set; }
        public string Description { get; set; }
        
        public ICollection<Commande> Commandes { get; set; }
    }

}
