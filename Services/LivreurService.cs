using app_back_.Models;
using Microsoft.EntityFrameworkCore;

namespace app_back_.Services
{
    public class LivreurService : ILivreurService
    {
        private readonly ApplicationDbContext _context;


        public LivreurService(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<Livreur> Add(Livreur livreur)
        {
            await _context.AddAsync(livreur);
            _context.SaveChanges();

            return livreur;
        }

        public Livreur Delete(Livreur livreur)
        {
            _context.Remove(livreur);
            _context.SaveChanges();

            return livreur;
        }

        public async Task<IEnumerable<Livreur>> GetAll()
        {
            return await _context.Livreurs.ToListAsync();

        }

        public async Task<Livreur> GetById(byte id)
        {
            return await _context.Livreurs.SingleOrDefaultAsync(c => c.IdLivreur == id);
        }

        public Task<bool> IsvalidGenre(byte id)
        {
            return _context.Livreurs.AnyAsync(g => g.IdLivreur == id);
        }

        public Livreur Update(Livreur livreur)
        {
            _context.Update(livreur);
            _context.SaveChanges();

            return livreur;
        }
    }
}
