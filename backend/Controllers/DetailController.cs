using backend.Models;
using backend.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DetailController : ControllerBase
    {
        private readonly IDetailServices _detailservices;

        public DetailController(IDetailServices detailservices)
        {
            _detailservices = detailservices;
        }

        //[HttpPost]
        //public async Task<IActionResult> SaveFormDetails(Detail formdetails)
        //{
        //    if (ModelState.IsValid)
        //    {

        //    }

        //}
    }
}