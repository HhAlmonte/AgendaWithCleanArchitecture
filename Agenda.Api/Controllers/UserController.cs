using Agenda.Application.User.Dtos;
using Agenda.Application.User.Handlers;
using Microsoft.AspNetCore.Mvc;

namespace Agenda.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserHandler _userHandler;
        public UserController(IUserHandler userHandler)
        {
            _userHandler = userHandler;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get([FromRoute]int id)
        {
            var entityToReturn = await _userHandler.GetById(id);

            if (entityToReturn == null)
                return NotFound();

            return Ok(entityToReturn);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody]UserPasswordDto userDto)
        {
            try
            {
                var entityToCreate = await _userHandler.Create(userDto);
                return Ok(entityToCreate);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
                throw;
            }
            
        }
    }
}
