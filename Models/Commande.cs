namespace RestaurantApi.Models
{
    public class Commande
    {
        public int NumCom { get; set; }
        public DateTime DatePreparation { get; set; }
        public int IdClient { get; set; }
        public int IdRestaurant { get; set; }
        public int IdStatus { get; set; }
        public int IdLivreur { get; set; }

        public int IdEtat { get; set; }


        public DateTime DateEnregistrement { get; set; }
        public DateTime DateSuppression { get; set; }
        public int GetNumCom(int numCom) { return numCom; }
        public Client Client { get; set; }
        public Restaurant Restaurant { get; set; }
        public Livreur Livreur { get; set; }
        public EtatCommande EtatCommande { get; set; }

        public StatusLivraison StatusLivraison { get; set; }




    }

}
