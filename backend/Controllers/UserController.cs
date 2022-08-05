using AutoMapper;
using backend.Models;
using backend.Models.DTO;
using backend.Models.DTO.Readonly;
using backend.Models.DTO.Update;
using backend.Models.Response;
using backend.Repository.Interfaces;
using backend.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserServices _userservices;
        private readonly IMapper mapper;

        public UserController(IUserServices userservices, IMapper mapper)
        {
            _userservices = userservices;
            this.mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<ICollection<UserReadOnly>>> GetUsers()
        {
            try
            {
                var users = await _userservices.GetListUserswithForms();
                if (users == null)
                {
                    return NotFound();
                }
                var model = mapper.Map<IEnumerable<UserReadOnly>>(users);
                return Ok(model);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


        [HttpGet("{id}")]
        public async Task<ActionResult<User>> Get(int id)
        {
            var user = await _userservices.GetbyId(id);
            if (user == null)
            {
                return NotFound();
            }
            var userdto = mapper.Map<UserReadOnly>(user);
            return Ok(userdto);
        }

        [HttpPost]
        public async Task<ActionResult<UserDTO>> CreatenewUser(UserDTO userDto)
        {
            var user = mapper.Map<User>(userDto);
            await _userservices.CreateUser(user);

            return Ok("ajouté");
        }

        [HttpPut]
        public async Task<IActionResult> PutUser(UserUpdate user)
        {
            var userres = await _userservices.GetbyId(user.Id);
            if (userres == null)
            {
                return NotFound();
            }
            var entity = mapper.Map<UserUpdate, User>(user);
            await _userservices.UpdateUser(entity);
            return Ok(entity);
        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> UserDelete(int id)
        {
            await _userservices.DeleteUserAsync(id);
            return NoContent();
        }

    }
}
