using backend.Models;

namespace backend.Services.Interfaces
{
    public interface IUserServices
    {
        List<User> GetListUsers();
    }
}
