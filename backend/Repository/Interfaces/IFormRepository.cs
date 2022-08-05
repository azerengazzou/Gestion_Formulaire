using backend.Models;

namespace backend.Repository.Interfaces
{
    public interface IFormRepository : IGenericRepository<Form>
    {
        Task<ICollection<Form>> GetAllwithUser();
    }
}
