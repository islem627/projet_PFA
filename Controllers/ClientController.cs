using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

[ApiController]
[Route("api/[controller]")]
public class ClientController : ControllerBase
{
    private readonly IClientService _clientService;

    public ClientController(IClientService clientService)
    {
        _clientService = clientService;
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

    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateClient(int id, [FromBody] Client client)
    {
        if (id != client.Id || !ModelState.IsValid)
            return BadRequest();

        var updatedClient = await _clientService.UpdateClientAsync(client);
        if (updatedClient == null)
            return NotFound();

        return Ok(updatedClient);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteClient(int id)
    {
        var success = await _clientService.DeleteClientAsync(id);
        if (!success)
            return NotFound();

        return NoContent();
    }
}
