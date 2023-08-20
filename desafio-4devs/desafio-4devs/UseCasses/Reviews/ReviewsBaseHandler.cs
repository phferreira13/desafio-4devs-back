using desafio_4devs_domain.Interfaces.Repostirories;

namespace desafio_4devs.UseCasses.Reviews
{
    public abstract class ReviewsBaseHandler
    {
        protected readonly IReviewRepository _repository;

        public ReviewsBaseHandler(IReviewRepository repository)
        {
            _repository = repository;
        }
    }
}
