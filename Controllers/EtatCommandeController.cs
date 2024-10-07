using app_back_.Dtos;
using app_back_.Models;
using app_back_.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace app_back_.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EtatCommandeController : ControllerBase
    {
        private readonly IEtatCommandeService _etatCommanderService;

        public EtatCommandeController(IEtatCommandeService etatCommanderService)
        {
            _etatCommanderService = etatCommanderService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAsync()
        {
            var etatCommandes = await _etatCommanderService.GetAll();

            return Ok(etatCommandes);
        }

        [HttpPost]
        public async Task<IActionResult> CreateAsync(CreateEtatCommandeDto dto)
        {
            var etatCommande = new EtatCommande
            {
                Description = dto.Description,
                
                
            };
            await _etatCommanderService.Add(etatCommande);
            return Ok(etatCommande);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateAsync(byte id, [FromBody] CreateEtatCommandeDto dto)
        {
            var etatCommande = await _etatCommanderService.GetById(id);

            if (etatCommande == null)
                return NotFound($"No etatCommande was found with ID: {id}");

            etatCommande.Description = dto.Description;


            // Save changes asynchronously
            _etatCommanderService.Update(etatCommande);
            return Ok(etatCommande);
        }




        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAsync(byte id)
        {
            var etatCommande = await _etatCommanderService.GetById(id);

            if (etatCommande == null)
                return NotFound($"No etatCommande was found with ID: {id}");

            _etatCommanderService.Delete(etatCommande);
            return Ok(etatCommande);
        }
    }
}
