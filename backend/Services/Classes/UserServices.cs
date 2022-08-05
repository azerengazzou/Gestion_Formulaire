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
        public async Task<IEnumerable<User>> GetListUserswithForms()
        {
            try
            {
                return await _servicesuser.GetAllwithform();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<User> GetbyId(int userid)
        {
            return await _servicesuser.GetByid(userid);
        }


        public async Task UpdateUser(User user)
        {
            await _servicesuser.Update(user);
        }

        public async Task CreateUser(User user)
        {
            await _servicesuser.Create(user);
        }

        public async Task DeleteUserAsync(int id)
        {
            await _servicesuser.Delete(await _servicesuser.GetByid(id));
        }
    }
}
