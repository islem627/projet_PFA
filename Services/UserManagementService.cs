using app_back_.Dtos;
using app_back_.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace app_back_.Services
{
    public class UserManagementService : IUserManagementService
    {
        private readonly ApplicationDbContext _context;

        public UserManagementService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<UserDto>> GetAllUsersAsync()
        {
            var clients = await _context.Clients.Select(c => new UserDto
            {
                Id = c.IdClient,
                Email = c.Email,
                Password = c.Password,
                Type = "Client"
            }).ToListAsync();

            var livreurs = await _context.Livreurs.Select(l => new UserDto
            {
                Id = l.IdLivreur,
                Email = l.Email,
                Password = l.Password,
                Type = "Livreur"
            }).ToListAsync();

            var restaurants = await _context.Restaurants.Select(r => new UserDto
            {
                Id = r.IdRestaurant,
                Email = r.Email,
                Password = r.Password,
                Type = "Restaurant"
            }).ToListAsync();

            return clients.Concat(livreurs).Concat(restaurants);
        }

        public async Task<UserDto> GetUserByIdAsync(byte id) // Changed int to byte
        {
            var client = await _context.Clients.FindAsync(id);
            if (client != null)
            {
                return new UserDto
                {
                    Id = client.IdClient,
                    Email = client.Email,
                    Password = client.Password,
                    Type = "Client"
                };
            }

            var livreur = await _context.Livreurs.FindAsync(id);
            if (livreur != null)
            {
                return new UserDto
                {
                    Id = livreur.IdLivreur,
                    Email = livreur.Email,
                    Password = livreur.Password,
                    Type = "Livreur"
                };
            }

            var restaurant = await _context.Restaurants.FindAsync(id);
            if (restaurant != null)
            {
                return new UserDto
                {
                    Id = restaurant.IdRestaurant,
                    Email = restaurant.Email,
                    Password = restaurant.Password,
                    Type = "Restaurant"
                };
            }

            return null; // Si aucun utilisateur n'est trouvé
        }

        public async Task<bool> UpdateUserAsync(byte id, UserUpdateDto userUpdateDto) // Changed int to byte
        {
            var client = await _context.Clients.FindAsync(id);
            if (client != null)
            {
                client.Email = userUpdateDto.Email;
                client.Password = userUpdateDto.Password;
                await _context.SaveChangesAsync();
                return true;
            }

            var livreur = await _context.Livreurs.FindAsync(id);
            if (livreur != null)
            {
                livreur.Email = userUpdateDto.Email;
                livreur.Password = userUpdateDto.Password;
                await _context.SaveChangesAsync();
                return true;
            }

            var restaurant = await _context.Restaurants.FindAsync(id);
            if (restaurant != null)
            {
                restaurant.Email = userUpdateDto.Email;
                restaurant.Password = userUpdateDto.Password;
                await _context.SaveChangesAsync();
                return true;
            }

            return false; // Si aucun utilisateur n'est trouvé
        }

        public async Task<bool> DeleteUserAsync(byte id) // Changed int to byte
        {
            var client = await _context.Clients.FindAsync(id);
            if (client != null)
            {
                _context.Clients.Remove(client);
                await _context.SaveChangesAsync();
                return true;
            }

            var livreur = await _context.Livreurs.FindAsync(id);
            if (livreur != null)
            {
                _context.Livreurs.Remove(livreur);
                await _context.SaveChangesAsync();
                return true;
            }

            var restaurant = await _context.Restaurants.FindAsync(id);
            if (restaurant != null)
            {
                _context.Restaurants.Remove(restaurant);
                await _context.SaveChangesAsync();
                return true;
            }

            return false; // Si aucun utilisateur n'est trouvé
        }
    }
}
