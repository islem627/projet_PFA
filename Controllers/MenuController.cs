using Microsoft.AspNetCore.Mvc;
using RestaurantApi.Models;

[ApiController]
[Route("api/[controller]")]
public class MenuController : ControllerBase
{
    [HttpPost]
    public IActionResult CreateMenu([FromBody] Menu menu)
    {
        // Logic to create a new Menu
    }

    [HttpGet("{id}")]
    public IActionResult GetMenu(int id)
    {
        // Logic to retrieve a specific Menu by ID
    }

    [HttpPut("{id}")]
    public IActionResult UpdateMenu(int id, [FromBody] Menu menu)
    {
        // Logic to update a specific Menu
    }

    [HttpDelete("{id}")]
    public IActionResult DeleteMenu(int id)
    {
        // Logic to delete a specific Menu
    }

    [HttpGet("{id}/items")]
    public IActionResult GetMenuItems(int id)
    {
        // Logic to retrieve all items in a specific Menu
    }

    [HttpPost("{id}/items")]
    public IActionResult AddItemToMenu(int id, [FromBody] Item item)
    {
        // Logic to add a new Item to a specific Menu
    }

    [HttpDelete("{id}/items/{itemId}")]
    public IActionResult RemoveItemFromMenu(int id, int itemId)
    {
        // Logic to remove an Item from a specific Menu
    }
}
