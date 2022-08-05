using backend.Models;
using backend.Repository.Interfaces;
using backend.Services.Interfaces;

namespace backend.Services.Classes
{
    public class CmpServices : ICmpServices
    {

        public readonly ICmpoRepository _servicesCMP;
        public CmpServices(ICmpoRepository cmpservices)
        {
            _servicesCMP = cmpservices;
        }
        public async Task<IEnumerable<Cmp>> GetListCMPwithDetails()
        {
            try
            {
                return await _servicesCMP.GetAllwithDetails();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<Cmp> GetbyId(int cmpId)
        {
            return await _servicesCMP.GetByid(cmpId);
        }


        public async Task UpdateCmp(Cmp cmp)
        {
            await _servicesCMP.Update(cmp);
        }

        public async Task CreateCmp(Cmp cmp)
        {
            await _servicesCMP.Create(cmp);
        }

        public async Task DeleteCmpAsync(int id)
        {
            await _servicesCMP.Delete(await _servicesCMP.GetByid(id));
        }
    }
}
