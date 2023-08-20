using desafio_4devs_domain.Interfaces.Repostirories;
using MediatR;

namespace desafio_4devs.UseCasses.Reviews.Result
{
    public class ReviewsResultHandler : ReviewsBaseHandler, IRequestHandler<ReviewsResultQuery, ReviewsResultResponse>
    {
        public ReviewsResultHandler(IReviewRepository repository) : base(repository)
        {
        }

        public async Task<ReviewsResultResponse> Handle(ReviewsResultQuery request, CancellationToken cancellationToken)
        {
            var reviews = await _repository.GetReviewResult(request.ReferenceMonth, request.ReferenceYear);
            return new ReviewsResultResponse { ReviewResult = reviews };
        }
    }
}
