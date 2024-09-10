using Microsoft.AspNetCore.Mvc;
using RestaurantApi.Models;

[ApiController]
[Route("api/[controller]")]
public class CommandeController : ControllerBase
{
    [HttpPost]
    public IActionResult CreateCommande([FromBody] Commande commande)
    {
        // Logic to create a new Commande
    }

    [HttpGet("{id}")]
    public IActionResult GetCommande(int id)
    {
        // Logic to retrieve a specific Commande by ID
    }

    [HttpPut("{id}")]
    public IActionResult UpdateCommande(int id, [FromBody] Commande commande)
    {
        // Logic to update a specific Commande
    }

    [HttpDelete("{id}")]
    public IActionResult DeleteCommande(int id)
    {
        // Logic to delete a specific Commande
    }

    [HttpGet("{id}/etat")]
    public IActionResult GetEtatCommande(int id)
    {
        // Logic to get the status of a specific Commande
    }
}
}