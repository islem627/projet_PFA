using app_back_.Dtos;
using app_back_.Models;
using app_back_.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace app_back_.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RestaurantController : ControllerBase
    {
        private readonly IRestaurantService _restaurantService;

        public RestaurantController(IRestaurantService restaurantService)
        {
            _restaurantService = restaurantService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAsync()
        {
            var restaurants = await _restaurantService.GetAll();

            return Ok(restaurants);
        }

        [HttpPost]
        public async Task<IActionResult> CreateAsync(CreateRestaurantDto dto)
        {
            var restaurant = new Restaurant
            {
                Horaire = dto.Horaire,
                Email = dto.Email,
                Prenom = dto.Prenom,
                Nom = dto.Nom,
                Password = dto.Password,
                Adresse = dto.Adresse,
                NumTel = dto.NumTel,
            };
            await _restaurantService.Add(restaurant);
            return Ok(restaurant);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateAsync(byte id, [FromBody] CreateRestaurantDto dto)
        {
            var restaurant = await _restaurantService.GetById(id);

            if (restaurant == null)
                return NotFound($"No restaurant was found with ID: {id}");

              restaurant.Horaire = dto.Horaire;
              restaurant.Email = dto.Email;
             restaurant.Prenom = dto.Prenom;
             restaurant.Nom = dto.Nom;
             restaurant.Password = dto.Password;
             restaurant.Adresse = dto.Adresse;
             restaurant.NumTel = dto.NumTel;

            // Save changes asynchronously
            _restaurantService.Update(restaurant);
            return Ok(restaurant);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAsync(byte id)
        {
            var restaurant = await _restaurantService.GetById(id);

            if (restaurant == null)
                return NotFound($"No restaurant was found with ID: {id}");

            _restaurantService.Delete(restaurant);
            return Ok(restaurant);
        }
    }
}
