using MediatR;

namespace desafio_4devs.UseCasses.Reviews.Result
{
    public class ReviewsResultQuery : IRequest<ReviewsResultResponse>
    {
        public required string ReferenceMonth { get; set; }
        public required string ReferenceYear { get; set; }
    }
}
