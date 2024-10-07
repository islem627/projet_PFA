using app_back_.Dtos;
using app_back_.Models;
using app_back_.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace app_back_.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientsController : ControllerBase
    {
        private readonly IClientService _clientService;
        public ClientsController(IClientService clientService)

        {
            _clientService = clientService;
        }



        [HttpGet]
        public async Task<IActionResult> GetAllAsync()
        {
            var clients = await _clientService.GetAll();

            return Ok(clients);
        }

        [HttpPost]
        public async Task<IActionResult> CreateAsync(CreateClientDto dto)
        {
            var client = new Client
            {
                Horaire = dto.Horaire,
                Email = dto.Email,
                Prenom = dto.Prenom,
                Nom = dto.Nom,
                Password = dto.Password,
                Adresse = dto.Adresse,
                NumTel = dto.NumTel,
            };
            await _clientService.Add(client);
            return Ok(client);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateAsync(byte id, [FromBody] CreateClientDto dto)
        {
            // Retrieve the client with the specified IdClient
            var client = await _clientService.GetById(id);

            // Check if the client exists
            if (client == null)
                return NotFound($"No client was found with ID: {id}");

            // Update client properties
            client.Horaire = dto.Horaire;
            client.Email = dto.Email;
            client.Prenom = dto.Prenom;
            client.Nom = dto.Nom;
            client.Password = dto.Password;
            client.Adresse = dto.Adresse;
            client.NumTel = dto.NumTel;

            // Save changes asynchronously
            _clientService.Update(client);
            return Ok(client);
        }




        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAsync(byte id)
        {
            // Retrieve the client with the specified IdClient
            var client = await _clientService.GetById(id);

            // Check if the client exists
            if (client == null)
                return NotFound($"No client was found with ID: {id}");

            _clientService.Delete(client);
            return Ok(client);
        }

    }
}
    
        