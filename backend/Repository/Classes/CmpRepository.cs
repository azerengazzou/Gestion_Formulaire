using backend.Models;
using backend.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace backend.Repository.Classes
{
    public class CmpRepository : GenericRepository<Cmp>, ICmpoRepository
    {
        public CmpRepository(DBFormContext context) : base(context)
        {

        }
        public async Task<ICollection<Cmp>> GetAllwithDetails()
        {
            return await _context.Cmps.Include(x => x.CmpDetails).ThenInclude(k=>k.IdCmpNavigation).ToListAsync();
        }
    }
}
