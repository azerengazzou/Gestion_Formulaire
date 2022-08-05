using backend.Models;
using backend.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace backend.Repository.Classes
{
    public class UserRepository : GenericRepository<User>, IUserRepository
    {

        public UserRepository(DBFormContext context) : base(context)
        {

        }
        public async Task<ICollection<User>> GetAllwithform()
        {
            return await _context.Users.Include(q => q.Forms).ToListAsync();
        }


    }
}
