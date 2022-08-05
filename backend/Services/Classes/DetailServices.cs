using backend.Models;
using backend.Repository.Interfaces;
using backend.Services.Interfaces;

namespace backend.Services.Classes
{
    public class DetailServices : IDetailServices
    {
        public readonly IDetailRepository _serviceDetails;
        public DetailServices(IDetailRepository detailservice)
        {
            _serviceDetails = detailservice;
        }

        public async Task<IEnumerable<Detail>> GetListDetailswithCMP()
        {
            try
            {
                return await _serviceDetails.GetAllwithCMP();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<Detail> GetbyId(int DetailId)
        {
            return await _serviceDetails.GetByid(DetailId);
        }


        public async Task UpdateDetail(Detail detail)
        {
            await _serviceDetails.Update(detail);
        }

        public async Task CreateDetail(Detail detail)
        {
            await _serviceDetails.Create(detail);
        }

        public async Task DeleteDetailAsync(int id)
        {
            await _serviceDetails.Delete(await _serviceDetails.GetByid(id));
        }
    }
}
