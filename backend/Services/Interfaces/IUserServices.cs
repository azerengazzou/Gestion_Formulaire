using backend.Models;

namespace backend.Services.Interfaces
{
    public interface IUserServices
    {
        Task<User> GetbyId(int userid);
        Task<IEnumerable<User>> GetListUserswithForms();
        Task DeleteUserAsync(int id);
        Task UpdateUser(User user);
        Task CreateUser(User user);
    }
}
