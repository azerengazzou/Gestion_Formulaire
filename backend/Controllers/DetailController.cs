using AutoMapper;
using backend.Models;
using backend.Models.DTO;
using backend.Models.DTO.Readonly;
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
        private readonly IMapper mapper;

        public DetailController(IDetailServices detailservices,IMapper mapper)
        {
            _detailservices = detailservices;
            this.mapper = mapper;
        }
        [HttpGet]
        public async Task<ActionResult<ICollection<DetailsReadOnly>>> GetForms()
        {
            try
            {
                var details = await _detailservices.GetListDetailswithCMP();
                if (details == null)
                {
                    return NotFound();
                }
                var model = mapper.Map<ICollection<DetailsReadOnly>>(details);
                return Ok(model);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


        [HttpGet("{id}")]
        public async Task<ActionResult<Detail>> Get(int id)
        {
            var details = await _detailservices.GetbyId(id);
            if (details == null)
            {
                return NotFound();
            }
            var detaildto = mapper.Map<DetailsReadOnly>(details);
            return Ok(detaildto);
        }

        [HttpPost]
        public async Task<ActionResult<DetailsDTO>> CreatenewDetails(DetailsDTO detaildto)
        {
            var detail = mapper.Map<Detail>(detaildto);
            await _detailservices.CreateDetail(detail);

            return Ok("ajouté");
        }

        //[HttpPut("{id}")]
        //public async Task<IActionResult> PutDetail(int id, DetailUpdate form)
        //{
        //    var formres = await _detailservices.GetbyId(id);
        //    if (formres == null)
        //    {
        //        return NotFound();
        //    }
        //    var entity = mapper.Map<Form>(form);
        //    await _detailservices.UpdateForm(entity);
        //    return Ok(entity);
        //}


        [HttpDelete("{id}")]
        public async Task<IActionResult> DetailsDelete(int id)
        {
            await _detailservices.DeleteDetailAsync(id);
            return NoContent();
        }

    }
}