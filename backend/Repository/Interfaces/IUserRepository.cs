using backend.Models;

namespace backend.Repository.Interfaces
{
    public interface IUserRepository : IGenericRepository<User>
    {
        //IEnumerable<User> GetUsersByName(String Name);
    }
}
