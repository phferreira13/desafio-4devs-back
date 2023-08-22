using desafio_4devs_domain.DTOs.Reviews;
using desafio_4devs_domain.Interfaces.Repostirories.Base;
using desafio_4devs_domain.Models;

namespace desafio_4devs_domain.Interfaces.Repostirories
{
    public interface IReviewRepository : IBaseCrudRepository<Review>
    {
        Task<IEnumerable<Review>> GetByOrganizationId(int organizationId);
        Task<IEnumerable<Review>> GetByUserId(int userId);
        Task<IEnumerable<Review>> GetByOrganizationIdAndUserId(int organizationId, int userId);
        Task<IEnumerable<ReviewResultDto>> GetReviewResult(string referenceMonth, string referenceYear);
        Task<IEnumerable<Review>> AddReviews(IEnumerable<Review> reviews);
        Task<IEnumerable<ReviewResultDto>> GetReviewResult();
    }
}
