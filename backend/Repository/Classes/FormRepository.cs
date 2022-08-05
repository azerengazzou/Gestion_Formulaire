using backend.Models;
using backend.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace backend.Repository.Classes
{
    public class FormRepository : GenericRepository<Form>, IFormRepository
    {
        public FormRepository(DBFormContext context) : base(context)
        {

        }
        public async Task<ICollection<Form>> GetAllwithUser()
        {
            return await _context.Forms.Include(q => q.User).ToListAsync();
        }
    }
}