using desafio_4devs.UseCasses.Reviews.Add;
using desafio_4devs.UseCasses.Reviews.Get;
using desafio_4devs.UseCasses.Reviews.Result;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace desafio_4devs.Controllers
{
    [ApiController]
    [Route("api/review")]
    public class ReviewController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ReviewController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        [ProducesResponseType(typeof(ReviewsGetResponse), 200)]
        public async Task<IActionResult> Get()
        {
            var result = await _mediator.Send(new ReviewsGetQuery());
            return Ok(result);
        }

        [HttpGet("get-result")]
        [ProducesResponseType(typeof(ReviewsResultResponse), 200)]
        public async Task<IActionResult> GetResult([FromQuery] ReviewsResultQuery query)
        {
            var result = await _mediator.Send(query);
            return Ok(result);
        }

        [HttpPost]
        [ProducesResponseType(typeof(ReviewsAddResponse), 200)]
        public async Task<IActionResult> Add([FromBody] ReviewsAddCommand command)
        {
            try
            {
                var result = await _mediator.Send(command);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
