using Microsoft.AspNetCore.Mvc;
using RestaurantApi.Models;

[ApiController]
[Route("api/[controller]")]
public class ItemsController : ControllerBase
{
    [HttpPost]
    public IActionResult CreateItem([FromBody] Items item)
    {
        // Logic to create a new Item
    }

    [HttpGet("{id}")]
    public IActionResult GetItem(int id)
    {
        // Logic to retrieve a specific Item by ID
    }

    [HttpPut("{id}")]
    public IActionResult UpdateItem(int id, [FromBody] Items item)
    {
        // Logic to update a specific Item
    }

    [HttpDelete("{id}")]
    public IActionResult DeleteItem(int id)
    {
        // Logic to delete a specific Item
    }
}
