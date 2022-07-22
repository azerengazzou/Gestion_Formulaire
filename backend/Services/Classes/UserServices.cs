using backend.Models;
using backend.Repository.Classes;
using backend.Repository.Interfaces;
using backend.Services.Interfaces;

namespace backend.Services.Classes
{
    public class UserServices : IUserServices
    {
        public readonly IUserRepository _servicesuser;
        public UserServices(IUserRepository userservices)
        {
            _servicesuser = userservices;
        }
        public List<User> GetListUsers()
        {
            try
            {
                return (List<User>)_servicesuser.GetAll();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
