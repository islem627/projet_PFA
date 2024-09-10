using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

[ApiController]
[Route("api/[controller]")]
public class ClientController : ControllerBase
{
    private readonly IClientService _clientService;

    public ClientController()
    {
      
    }

    [HttpPost]
    public async Task<IActionResult> CreateClient([FromBody] Client client)
    {
        if (!ModelState.IsValid)
            return BadRequest(ModelState);

        var createdClient = await _clientService.CreateClientAsync(client);
        return CreatedAtAction(nameof(GetClient), new { id = createdClient.Id }, createdClient);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetClient(int id)
    {
        var client = await _clientService.GetClientByIdAsync(id);
        if (client == null)
            return NotFound();

        return Ok(client);
    }

  

}
