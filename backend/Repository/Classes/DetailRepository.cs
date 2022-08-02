using backend.Models;
using backend.Repository.Interfaces;

namespace backend.Repository.Classes
{
    public class DetailRepository : GenericRepository<Detail>, IDetailRepository
    {
        public DetailRepository(DBFormContext context) : base(context)
        {

        }
    }
}
