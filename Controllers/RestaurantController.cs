using Microsoft.AspNetCore.Mvc;
using RestaurantApi.Models;

[ApiController]
[Route("api/[controller]")]
public class RestaurantController : ControllerBase
{
    [HttpPost]
    public IActionResult CreateRestaurant([FromBody] Restaurant restaurant)
    {
        // Logic to create a new Restaurant
    }

    [HttpGet("{id}")]
    public IActionResult GetRestaurant(int id)
    {
        // Logic to retrieve a specific Restaurant by ID
    }

    [HttpPut("{id}")]
    public IActionResult UpdateRestaurant(int id, [FromBody] Restaurant restaurant)
    {
        // Logic to update a specific Restaurant
    }

    [HttpDelete("{id}")]
    public IActionResult DeleteRestaurant(int id)
    {
        // Logic to delete a specific Restaurant
    }

    [HttpGet("{id}/menu")]
    public IActionResult GetMenu(int id)
    {
        // Logic to get the menu of a restaurant
    }
}
