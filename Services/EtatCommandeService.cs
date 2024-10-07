using app_back_.Models;
using Microsoft.EntityFrameworkCore;

namespace app_back_.Services
{
    public class EtatCommandeService : IEtatCommandeService
    {  private readonly ApplicationDbContext _context;


    public EtatCommandeService(ApplicationDbContext context)
    {
        _context = context;
    }
       
        public async Task<EtatCommande> Add(EtatCommande etatCommande)
        {
            await _context.AddAsync(etatCommande);
            _context.SaveChanges();

            return etatCommande;
        }

        public EtatCommande Delete(EtatCommande etatCommande)
        {
            _context.Remove(etatCommande);
            _context.SaveChanges();

            return etatCommande;
        }

        public async Task<IEnumerable<EtatCommande>> GetAll()
        {
            return await _context.EtatCommandes.ToListAsync();

        }

        public async Task<EtatCommande> GetById(byte id)
        {
            return await _context.EtatCommandes.SingleOrDefaultAsync(c => c.IdEtat == id);
        }

        public Task<bool> IsvalidGenre(byte id)
        {
            return _context.EtatCommandes.AnyAsync(g => g.IdEtat == id);
        }

        public EtatCommande Update(EtatCommande etatCommande)
        {
            _context.Update(etatCommande);
            _context.SaveChanges();

            return etatCommande;
        }
    }
}

