using RestaurantApi.Models;

public interface IClientService
{
    Task<Client> CreateClientAsync(Client client);
    Task<Client> GetClientByIdAsync(int id);
    Task<Client> UpdateClientAsync(Client client);
    Task<bool> DeleteClientAsync(int id);
}
