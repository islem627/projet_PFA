using app_back_.Models;
using Microsoft.EntityFrameworkCore;

namespace app_back_.Services
{
 
    public class RestaurantService : IRestaurantService
    {
        private readonly ApplicationDbContext _context;


        public RestaurantService(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<Restaurant> Add(Restaurant restaurant)
        {
            await _context.AddAsync(restaurant);
            _context.SaveChanges();

            return restaurant;
        }

        public Restaurant Delete(Restaurant restaurant)
        {
            _context.Remove(restaurant);
            _context.SaveChanges();

            return restaurant;
        }

        public async Task<IEnumerable<Restaurant>> GetAll()
        {
            return await _context.Restaurants.ToListAsync();

        }

        public async Task<Restaurant> GetById(byte id)
        {
            return await _context.Restaurants.SingleOrDefaultAsync(c => c.IdRestaurant == id);
        }

        public Task<bool> IsvalidGenre(byte id)
        {
            return _context.Restaurants.AnyAsync(g => g.IdRestaurant == id);
        }

        public Restaurant Update(Restaurant restaurant)
        {
            _context.Update(restaurant);
            _context.SaveChanges();

            return restaurant;
        }
    }
}