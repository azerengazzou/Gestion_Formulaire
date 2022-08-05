using backend.Models;

namespace backend.Repository.Interfaces
{
    public interface IUserRepository : IGenericRepository<User>
    {
        Task<ICollection<User>> GetAllwithform();

    }
}
