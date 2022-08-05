using backend.Models;
using backend.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace backend.Repository.Classes
{
    public class DetailRepository : GenericRepository<Detail>, IDetailRepository
    {
        public DetailRepository(DBFormContext context) : base(context)
        {

        }
        public async Task<ICollection<Detail>> GetAllwithCMP()
        {
            return await _context.Details.Include(x => x.CmpDetails).ThenInclude(k => k.IdCmpNavigation).ToListAsync();
        }
    }
}
