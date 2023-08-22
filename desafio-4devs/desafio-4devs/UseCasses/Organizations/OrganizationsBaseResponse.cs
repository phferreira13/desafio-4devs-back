using desafio_4devs_domain.Enums;
using desafio_4devs_domain.Extensions;
using desafio_4devs_domain.Models;

namespace desafio_4devs.UseCasses.Organizations
{
    public abstract class OrganizationsBaseResponse
    {
        public required string Name { get; set; }
        public required string ContactName { get; set; }
        public string? Cnpj { get; set; }
        public List<OrganizationReviewBaseResponse> Reviews { get; set; } = new List<OrganizationReviewBaseResponse>();
        public string CategoryReview
        {
            get
            {
                return !Reviews.Any()
                    ? EOrganizationCategoryReview.None.GetDescription()
                    : GetReviewCategory(Reviews.OrderByDescending(r => r.CreatedAt).First()).GetDescription();
            }
        }

        private EOrganizationCategoryReview GetReviewCategory(OrganizationReviewBaseResponse review)
        {
            if(review.Rating > 9)
                return EOrganizationCategoryReview.Promoter;
            if(review.Rating > 6)
                return EOrganizationCategoryReview.Neutral;
            return EOrganizationCategoryReview.Detractor;
        }

        public DateTime? LastReviewDate 
        { 
            get 
            { 
                return !Reviews.Any() 
                    ? null
                    : Reviews.OrderByDescending(r => r.CreatedAt).First().CreatedAt;
            } 
        }
    }

    public class OrganizationReviewBaseResponse
    {
        public required int Rating { get; set; }
        public required DateTime CreatedAt { get; set; }

        public static implicit operator OrganizationReviewBaseResponse(Review review)
        {
            return new OrganizationReviewBaseResponse
            {
                Rating = review.Rating,
                CreatedAt = review.CreatedAt
            };
        }
    }
}
