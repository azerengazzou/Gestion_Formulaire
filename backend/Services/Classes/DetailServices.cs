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

        //public List<Detail> GetListDetails()
        //{
        //    try
        //    {
        //        return;
        //    }
        //    catch (Exception)
        //    {
        //        throw;
        //    }
        //}


        //public async Task<Detail> GetbyId(int detailid)
        //{
        //    return await _serviceDetails.GetByid(detailid);
        //}
    }
}
