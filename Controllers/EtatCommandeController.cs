using Microsoft.AspNetCore.Mvc;
using RestaurantApi.Models;

[ApiController]
[Route("api/[controller]")]
public class EtatCommandeController : ControllerBase
{
    [HttpGet("{id}")]
    public IActionResult GetEtatCommande(int id)
    {
        // Logic to get a specific EtatCommande
    }

    [HttpPost]
    public IActionResult CreateEtatCommande([FromBody] EtatCommande etatCommande)
    {
        // Logic to create a new EtatCommande
    }

    [HttpPut("{id}")]
    public IActionResult UpdateEtatCommande(int id, [FromBody] EtatCommande etatCommande)
    {
        // Logic to update a specific EtatCommande
    }

    [HttpDelete("{id}")]
    public IActionResult DeleteEtatCommande(int id)
    {
        // Logic to delete a specific EtatCommande
    }
}
