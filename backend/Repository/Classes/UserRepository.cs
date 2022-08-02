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
        //public IEnumerable<User> GetUsersByName(string username)
        //{
        //    return _context.Users.Include(d=>d.Fullname).ToList();
        //}
    }
}
