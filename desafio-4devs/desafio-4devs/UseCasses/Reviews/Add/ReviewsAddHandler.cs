using desafio_4devs_domain.Interfaces.Repostirories;
using MediatR;

namespace desafio_4devs.UseCasses.Reviews.Add
{
    public class ReviewsAddHandler : ReviewsBaseHandler, IRequestHandler<ReviewsAddCommand, ReviewsAddResponse>
    {
        public ReviewsAddHandler(IReviewRepository repository) : base(repository)
        {
        }

        public async Task<ReviewsAddResponse> Handle(ReviewsAddCommand request, CancellationToken cancellationToken)
        {
            var reviews = await _repository.AddReviews(request.GetReviews());
            return new ReviewsAddResponse { Reviews = reviews.ToList().ConvertAll<ReviewAddResponse>(r => r) };
        }
    }
}
