using app_back_.Models;

namespace app_back_.Services
{
    public interface IEtatCommandeService
    {
        Task<IEnumerable<EtatCommande>> GetAll();
        Task<EtatCommande> GetById(byte id);
        Task<EtatCommande> Add(EtatCommande etatCommande);
        EtatCommande Update(EtatCommande etatCommande);
        EtatCommande Delete(EtatCommande etatCommande);
    }
}
