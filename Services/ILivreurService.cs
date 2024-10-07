using app_back_.Models;

namespace app_back_.Services
{
    public interface ILivreurService
    {
        Task<IEnumerable<Livreur>> GetAll();
        Task<Livreur> GetById(byte id);
        Task<Livreur> Add(Livreur livreur);
        Livreur Update(Livreur livreur);
        Livreur Delete(Livreur livreur);
    }
}
