using backend.Models;

namespace backend.Services.Interfaces
{
    public interface ICmpServices
    {
        Task<IEnumerable<Cmp>> GetListCMPwithDetails();
        Task<Cmp> GetbyId(int cmpId);
        Task UpdateCmp(Cmp cmp);
        Task CreateCmp(Cmp cmp);
        Task DeleteCmpAsync(int id);
    }
}
