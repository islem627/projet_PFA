using app_back_.Models;

namespace app_back_.Services
{
    public interface IRestaurantService
    {
        Task<IEnumerable<Restaurant>> GetAll();
        Task<Restaurant> GetById(byte id);
        Task<Restaurant> Add(Restaurant restaurant);
        Restaurant Update(Restaurant restaurant);
        Restaurant Delete(Restaurant restaurant);
    }
}
