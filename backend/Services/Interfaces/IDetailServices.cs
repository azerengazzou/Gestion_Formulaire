using backend.Models;

namespace backend.Services.Interfaces
{
    public interface IDetailServices
    {
        Task<IEnumerable<Detail>> GetListDetailswithCMP();
        Task<Detail> GetbyId(int DetailId);
        Task UpdateDetail(Detail detail);
        Task CreateDetail(Detail detail);
        Task DeleteDetailAsync(int id);
    }
}
