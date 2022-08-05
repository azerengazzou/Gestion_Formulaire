using backend.Models;

namespace backend.Repository.Interfaces
{
    public interface IDetailRepository : IGenericRepository<Detail>
    {
        Task<ICollection<Detail>> GetAllwithCMP();
    }
}
