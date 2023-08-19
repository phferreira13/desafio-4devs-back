using desafio_4devs.UseCasses.Users.Add;
using desafio_4devs.UseCasses.Users.Get;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace desafio_4devs.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IMediator mediator;

        public UserController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<UsersGetResponse>), StatusCodes.Status200OK)]
        public async Task<IActionResult> Get()
        {
            var users = await mediator.Send(new UsersGetQuery());
            return Ok(users);
        }

        [HttpPost]
        [ProducesResponseType(typeof(UsersAddResponse), StatusCodes.Status201Created)]
        public async Task<IActionResult> Post([FromBody] UsersAddCommand command)
        {
            var user = await mediator.Send(command);
            return CreatedAtAction(nameof(Get), new { id = user.Id }, user);
        }


    }
}
