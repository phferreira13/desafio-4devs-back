using desafio_4devs.UseCasses.Reviews.Add;
using desafio_4devs.UseCasses.Reviews.Result;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace desafio_4devs.Controllers
{
    public class ReviewController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ReviewController(IMediator mediator)
        {
            _mediator = mediator;
        }       

        [HttpGet("get-result")]
        [ProducesResponseType(typeof(ReviewsResultResponse), 200)]
        public async Task<IActionResult> GetResult([FromQuery] ReviewsResultQuery query)
        {
            var result = await _mediator.Send(query);
            return Ok(result);
        }

        [HttpPost()]
        [ProducesResponseType(typeof(ReviewsAddResponse), 200)]
        public async Task<IActionResult> Add([FromBody] ReviewsAddCommand command)
        {
            var result = await _mediator.Send(command);
            return Ok(result);
        }
    }
}
