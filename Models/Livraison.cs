namespace RestaurantApi.Models
{
    public class Livraison
    {
        public float TransactionSpec { get; set; }
        public int IdLivreur { get; set; }
        public int IdLivraison { get; set; }
        public int NumCom { get; set; }
        public DateTime DateEnvoi { get; set; }
        public DateTime DateLivraison { get; set; }
        public DateTime DateArrivee { get; set; }

        public void GetIdLivraison(int idLivraison) { }
    }

}
