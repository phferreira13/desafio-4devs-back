using desafio_4devs.UseCasses.Organizations.Add;
using desafio_4devs.UseCasses.Organizations.Get;
using desafio_4devs.UseCasses.Organizations.GetByName;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace desafio_4devs.Controllers
{
    [ApiController]
    [Route("api/organization")]
    public class OrganizationController : ControllerBase
    {
        private readonly IMediator mediator;

        public OrganizationController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpGet]
        [ProducesResponseType(typeof(OrganizationsGetResponse), StatusCodes.Status200OK)]
        public async Task<IActionResult> Get()
        {
            var organizations = await mediator.Send(new OrganizationsGetQuery());
            return Ok(organizations);
        }

        [HttpPost]
        [ProducesResponseType(typeof(OrganizationsAddResponse), StatusCodes.Status201Created)]
        public async Task<IActionResult> Post([FromBody] OrganizationsAddCommand command)
        {
            var organization = await mediator.Send(command);
            return CreatedAtAction(nameof(Get), new { id = organization.Id }, organization);
        }

        [HttpGet("get-by-name")]
        [ProducesResponseType(typeof(OrganizationsGetByNameResponse), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetByName([FromQuery] OrganizationsGetByNameQuery query)
        {
            var organizations = await mediator.Send(query);
            return Ok(organizations);
        }
    }
}
