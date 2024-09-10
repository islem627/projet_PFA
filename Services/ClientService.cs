
public class ClientService : IClientService
{
    private readonly ApplicationDbContext _context;

    public ClientService(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<Client> CreateClientAsync(Client client)
    {
        _context.Clients.Add(client);
        await _context.SaveChangesAsync();
        return client;
    }

    public async Task<Client> GetClientByIdAsync(int id)
    {
        return await _context.Clients.FindAsync(id);
    }

   

    
}
