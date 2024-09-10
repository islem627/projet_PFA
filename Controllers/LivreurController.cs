using Microsoft.AspNetCore.Mvc;
using RestaurantApi.Models;

[ApiController]
[Route("api/[controller]")]
public class LivraisonController : ControllerBase
{
    [HttpPost]
    public IActionResult CreateLivraison([FromBody] Livraison livraison)
    {
        // Logic to create a new Livraison
    }

    [HttpGet("{id}")]
    public IActionResult GetLivraison(int id)
    {
        // Logic to retrieve a specific Livraison by ID
    }

    [HttpPut("{id}")]
    public IActionResult UpdateLivraison(int id, [FromBody] Livraison livraison)
    {
        // Logic to update a specific Livraison
    }

    [HttpDelete("{id}")]
    public IActionResult DeleteLivraison(int id)
    {
        // Logic to delete a specific Livraison
    }

    [HttpGet("{id}/status")]
    public IActionResult GetStatusLivraison(int id)
    {
        // Logic to get the status of a specific Livraison
    }
}
