using desafio_4devs_domain.DTOs.Reviews;

namespace desafio_4devs.UseCasses.Reviews.Get
{
    public class ReviewsGetResponse
    {
        public required IEnumerable<ReviewResultDto> ReviewResults { get; set; }
    }
}
