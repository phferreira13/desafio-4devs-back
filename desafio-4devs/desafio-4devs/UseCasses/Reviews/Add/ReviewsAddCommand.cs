using desafio_4devs_domain.Models;
using MediatR;

namespace desafio_4devs.UseCasses.Reviews.Add
{
    public class ReviewsAddCommand : IRequest<ReviewsAddResponse>
    {
        public int UserId { get; set; }
        public required string ReferenceMonth { get; set; }
        public required string ReferenceYear { get; set; }
        public required IEnumerable<OrganizationReviewAddCommand> OrganizationReviews { get; set; }

        public List<Review> GetReviews()
        {
            return OrganizationReviews.Select(organizationReview => new Review
            {
                UserId = UserId,
                ReferenceMonth = ReferenceMonth,
                ReferenceYear = ReferenceYear,
                Comment = organizationReview.Comment,
                Rating = organizationReview.Rating,
                OrganizationId = organizationReview.OrganizationId
            }).ToList();
        }
    }

    public class OrganizationReviewAddCommand
    {
        public required int OrganizationId { get; set; }
        public required string Comment { get; set; }
        public int Rating { get; set; }
    }
}
