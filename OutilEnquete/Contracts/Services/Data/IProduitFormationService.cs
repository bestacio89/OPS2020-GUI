using System.Collections.Generic;
using System.Threading.Tasks;
using OPS.BOL;

namespace OPS.UIWEB.Contracts.Data
{
    public interface IProduitFormationService
    {
        Task<IEnumerable<ProduitFormation>> GetAllProduitsAsync();
        Task<IEnumerable<ProduitFormation>> GetProduitParLibelleAsync();
        Task<IEnumerable<ProduitFormation>> GetProduitParLibelleCourteAsync();
    }
}
