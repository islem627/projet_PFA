namespace RestaurantApi.Models
{
    public class Items
    {
        public string Nom { get; set; }
        public string Description { get; set; }
        public float PrixRepas { get; set; }
        public int IdRepas { get; set; }
        public int IdMenu { get; set; }
    }

}
