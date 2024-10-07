using app_back_.Models;
using Microsoft.EntityFrameworkCore;

namespace app_back_.Services
{
    public class ClientService : IClientService
    {
    private readonly ApplicationDbContext _context;


        public ClientService(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<Client> Add(Client client)
        {
            await _context.AddAsync(client);
            _context.SaveChanges();

            return client;
        }

        public Client Delete(Client client)
        {
            _context.Remove(client);
            _context.SaveChanges();

            return client;
        }
        
        public async Task<IEnumerable<Client>> GetAll()
        {
            return await _context.Clients.ToListAsync();
           
        }

        public async Task<Client> GetById(byte id)
        {
            return await _context.Clients.SingleOrDefaultAsync(c => c.IdClient == id);
        }

        public Task<bool> IsvalidGenre(byte id)
        {
            return _context.Clients.AnyAsync(g => g.IdClient == id);
        }

        public Client Update(Client client)
        {
            _context.Update(client);
            _context.SaveChanges();

            return client;
        }
    }
}
