using desafio_4devs_domain.Models;

namespace desafio_4devs.UseCasses.Reviews.Add
{
    public class ReviewsAddResponse
    {
        public required IEnumerable<ReviewAddResponse> Reviews { get; set; }
    }

    public class ReviewAddResponse
    {
        public required int Id { get; set; }
        public required string ReferenceMonth { get; set; }
        public required string ReferenceYear { get; set; }
        public required int Rating { get; set; }
        public required string Comment { get; set; }
        public required int OrganizationId { get; set; }
        public required int UserId { get; set; }

        public static implicit operator ReviewAddResponse(Review review)
        {
            return new ReviewAddResponse
            {
                Id = review.Id,
                ReferenceMonth = review.ReferenceMonth,
                ReferenceYear = review.ReferenceYear,
                Rating = review.Rating,
                Comment = review.Comment,
                OrganizationId = review.OrganizationId,
                UserId = review.UserId
            };
        }

    }
}
