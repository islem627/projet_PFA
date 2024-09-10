namespace RestaurantApi.Models
{
    public class Menu
    {
        public int IdMenu { get; set; }
        public string Categories { get; set; }
        public string Description { get; set; }
        public int IdRestaurant { get; set; }
    }

}
