using backend.Models;
using backend.Repository.Interfaces;

namespace backend.Repository.Classes
{
    public class CmpRepository : GenericRepository<Cmp> , ICmpoRepository
    {
        public CmpRepository(DBFormContext context) : base(context)
        {

        }
    }
}
