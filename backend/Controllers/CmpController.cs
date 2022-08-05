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
    public class CmpController : ControllerBase
    {
        private readonly ICmpServices _cmpservices;
        private readonly IMapper mapper;

        public CmpController(ICmpServices cmpservices, IMapper mapper)
        {
            _cmpservices = cmpservices;
            this.mapper = mapper;
        }
        [HttpGet]
        public async Task<ActionResult<ICollection<CmpReadOnly>>> GetForms()
        {
            try
            {
                var cmps = await _cmpservices.GetListCMPwithDetails();
                if (cmps == null)
                {
                    return NotFound();
                }
                var model = mapper.Map<ICollection<CmpReadOnly>>(cmps);
                return Ok(model);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


        [HttpGet("{id}")]
        public async Task<ActionResult<Cmp>> Get(int id)
        {
            var details = await _cmpservices.GetbyId(id);
            if (details == null)
            {
                return NotFound();
            }
            var detaildto = mapper.Map<CmpReadOnly>(details);
            return Ok(detaildto);
        }

        [HttpPost]
        public async Task<ActionResult<CmpDTO>> CreatenewDetails(CmpDTO cmpdto)
        {
            var cmp = mapper.Map<Cmp>(cmpdto);
            await _cmpservices.CreateCmp(cmp);

            return Ok("ajouté");
        }

        //[HttpPut("{id}")]
        //public async Task<IActionResult> PutDetail(int id, DetailUpdate form)
        //{
        //    var formres = await _cmpservices.GetbyId(id);
        //    if (formres == null)
        //    {
        //        return NotFound();
        //    }
        //    var entity = mapper.Map<Form>(form);
        //    await _cmpservices.UpdateForm(entity);
        //    return Ok(entity);
        //}


        [HttpDelete("{id}")]
        public async Task<IActionResult> CmpDelete(int id)
        {
            await _cmpservices.DeleteCmpAsync(id);
            return NoContent();
        }
    }
}
