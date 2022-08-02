using AutoMapper;
using backend.Models;
using backend.Models.DTO;
using backend.Models.DTO.Readonly;
using backend.Models.DTO.Update;
using backend.Models.Response;
using backend.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FormController : ControllerBase
    {


        private readonly IFormServices _formservices;
        private readonly IMapper mapper;

        public FormController(IFormServices formservices,IMapper mapper)
        {
            _formservices = formservices;
            this.mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<ICollection<FormReadOnly>>> GetForms()
        {
            try
            {
                var forms = await _formservices.GetListForms();
                if (forms == null)
                {
                    return NotFound();
                }
                var model = mapper.Map<Form>(forms);
                return Ok(model);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


        [HttpGet("{id}")]
        public async Task<ActionResult<Form>> Get(int id)
        {
            var forms = await _formservices.GetbyId(id);
            if (forms == null)
            {
                return NotFound();
            }
            var formdto = mapper.Map<FormReadOnly>(forms);
            return Ok(formdto);
        }

        [HttpPost]
        public async Task<ActionResult<FormDTO>> CreatenewForm(FormDTO formDto)
        {
            var form = mapper.Map<Form>(formDto);
            await _formservices.CreateForm(form);

            return Ok("ajouté");
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutForm(int id, FormUpdate form)
        {
            var formres = await _formservices.GetbyId(id);
            if (formres == null)
            {
                return NotFound();
            }
            var entity = mapper.Map<Form>(form);
            await _formservices.UpdateForm(entity);
            return Ok(entity);
        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> FormDelete(int id)
        {
            await _formservices.DeleteFormAsync(id);
            return NoContent();
        }

    }
}