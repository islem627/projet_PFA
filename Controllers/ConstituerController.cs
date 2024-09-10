using Microsoft.AspNetCore.Mvc;
using RestaurantApi.Models;

[ApiController]
[Route("api/[controller]")]
public class ConstituerController : ControllerBase
{
    [HttpPost]
    public IActionResult CreateConstituer([FromBody] Constituer constituer)
    {
        // Logic to associate an item with a menu
    }

    [HttpGet("{menuId}/{itemId}")]
    public IActionResult GetConstituer(int menuId, int itemId)
    {
        // Logic to retrieve a specific association between a Menu and an Item
    }

    [HttpPut("{menuId}/{itemId}")]
    public IActionResult UpdateConstituer(int menuId, int itemId, [FromBody] Constituer constituer)
    {
        // Logic to update the association (e.g., quantity) between a Menu and an Item
    }

    [HttpDelete("{menuId}/{itemId}")]
    public IActionResult DeleteConstituer(int menuId, int itemId)
    {
        // Logic to delete the association between a Menu and an Item
    }
}
