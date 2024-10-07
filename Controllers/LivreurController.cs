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
    public class LivreurController : ControllerBase
    {
            private readonly ILivreurService _livreurService;

        public LivreurController(ILivreurService livreurService)
        {
            _livreurService = livreurService;
        }

        [HttpGet]
            public async Task<IActionResult> GetAllAsync()
            {
                var livreurs = await _livreurService.GetAll();

                return Ok(livreurs);
            }

        [HttpPost]
        public async Task<IActionResult> CreateAsync(CreateLivreurDto dto)
        {
            var livreur = new Livreur
            {
                Horaire = dto.Horaire,
                Email = dto.Email,
                Prenom = dto.Prenom,
                Nom = dto.Nom,
                Password = dto.Password,
                Adresse = dto.Adresse,
                NumTel = dto.NumTel,
            };
            await _livreurService.Add(livreur);
            return Ok(livreur);
        }

            [HttpPut("{id}")]
            public async Task<IActionResult> UpdateAsync(byte id, [FromBody] CreateLivreurDto dto)
            {
                var livreur = await _livreurService.GetById(id);

                if (livreur == null)
                    return NotFound($"No livreur was found with ID: {id}");

            livreur.Horaire = dto.Horaire;
            livreur.Email = dto.Email;
            livreur.Prenom = dto.Prenom;
            livreur.Nom = dto.Nom;
            livreur.Password = dto.Password;
            livreur.Adresse = dto.Adresse;
            livreur.NumTel = dto.NumTel;

            // Save changes asynchronously
            _livreurService.Update(livreur);
                return Ok(livreur);
            }




            [HttpDelete("{id}")]
            public async Task<IActionResult> DeleteAsync(byte id)
            {
                var livreur = await _livreurService.GetById(id);

                if (livreur == null)
                    return NotFound($"No livreur was found with ID: {id}");

            _livreurService.Delete(livreur);
                return Ok(livreur);
            }
        }
}
