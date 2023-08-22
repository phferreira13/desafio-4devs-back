using desafio_4devs.UseCasses.Reviews.Result;
using desafio_4devs_domain.Interfaces.Repostirories;
using MediatR;

namespace desafio_4devs.UseCasses.Reviews.Get
{
    public class ReviewsGetHandler : ReviewsBaseHandler, IRequestHandler<ReviewsGetQuery, ReviewsGetResponse>
    {
        public ReviewsGetHandler(IReviewRepository repository) : base(repository)
        {
        }

        public async Task<ReviewsGetResponse> Handle(ReviewsGetQuery request, CancellationToken cancellationToken)
        {
            var reviews = await _repository.GetReviewResult();
            return new ReviewsGetResponse
            {
                ReviewResults = reviews
            };
        }
    }
}
