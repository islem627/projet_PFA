using Microsoft.AspNetCore.Mvc;
using RestaurantApi.Models;

[ApiController]
[Route("api/[controller]")]
public class StatusLivraisonController : ControllerBase
{
    [HttpPost]
    public IActionResult CreateStatusLivraison([FromBody] StatusLivraison statusLivraison)
    {
        // Logic to create a new StatusLivraison
    }

    [HttpGet("{id}")]
    public IActionResult GetStatusLivraison(int id)
    {
        // Logic to retrieve a specific StatusLivraison by ID
    }

    [HttpPut("{id}")]
    public IActionResult UpdateStatusLivraison(int id, [FromBody] StatusLivraison statusLivraison)
    {
        // Logic to update a specific StatusLivraison
    }

    [HttpDelete("{id}")]
    public IActionResult DeleteStatusLivraison(int id)
    {
        // Logic to delete a specific StatusLivraison
    }
}
