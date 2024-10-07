using app_back_.Models;

namespace app_back_.Services
{
    public interface IClientService
    {
        Task<IEnumerable<Client>> GetAll();
        Task<Client> GetById(byte id);
        Task<Client> Add(Client client);
        Client Update(Client client);
        Client Delete(Client client);
    }
}
