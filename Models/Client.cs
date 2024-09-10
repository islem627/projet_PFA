namespace RestaurantApi.Models
{
    public class Client : Compte
    {
        public byte IdClient { get; set; }
        public DateTime Horaire { get; set; }
        [MaxLength(20)]
        public string Email { get; set; }
        [MaxLength(20)]
        public string Prenom { get; set; }
        [MaxLength(20)]
        public string Nom { get; set; }
        [MaxLength(8)]
        public string Password { get; set; }
        [MaxLength(20)]
        public string Adresse { get; set; }
        [MaxLength(8)]
        public string NumTel { get; set; }


        public void ChangerCoordonner() { }
        public void Commander() { }
        public void Annuler() { }
        public ICollection<Commande> Commandes { get; set; }

    }

}
