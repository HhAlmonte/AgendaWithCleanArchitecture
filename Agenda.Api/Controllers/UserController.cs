using Agenda.Application.User.Handlers;
using Microsoft.AspNetCore.Http;
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
        public async Task<IActionResult> Get(int id)
        {
            var entityToReturn = _userHandler.GetById(id);

            return Ok(entityToReturn);
        }
    }
}
