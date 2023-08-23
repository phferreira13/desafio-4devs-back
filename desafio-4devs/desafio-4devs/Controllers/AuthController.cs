using desafio_4devs.UseCasses.Users.Login;
using desafio_4devs_domain.Exceptions;
using desafio_4devs_domain.Extensions;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;


namespace desafio_4devs.Controllers
{
    [Route("api/auth")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IMediator mediator;

        public AuthController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [AllowAnonymous]
        [HttpPost("login")]
        [ProducesResponseType(typeof(UsersLoginResponse), StatusCodes.Status200OK)]
        public async Task<IActionResult> Login([FromBody] UsersLoginCommand command)
        {
            var userLogin = await mediator.Send(command);

            if (userLogin.User == null)
                return BadRequest(EUserException.UserNotFound.GetDescription());

            return Ok(userLogin);
        }
    }
}
