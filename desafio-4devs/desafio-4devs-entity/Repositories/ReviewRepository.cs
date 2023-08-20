using desafio_4devs_domain.DTOs.Reviews;
using desafio_4devs_domain.Interfaces.Repostirories;
using desafio_4devs_domain.Models;
using desafio_4devs_entity.Context;
using desafio_4devs_entity.Repositories.Base;
using Microsoft.EntityFrameworkCore;

namespace desafio_4devs_entity.Repositories
{
    public class ReviewRepository : BaseCrudRepository<Review>, IReviewRepository
    {
        public ReviewRepository(App4DevsContext context) : base(context)
        {
        }

        public async Task<IEnumerable<Review>> GetByOrganizationId(int organizationId)
        {
            return await _dbSet.Where(r => r.OrganizationId == organizationId).ToListAsync();
        }

        public async Task<IEnumerable<Review>> GetByOrganizationIdAndUserId(int organizationId, int userId)
        {
            return await _dbSet.Where(r => r.OrganizationId == organizationId && r.UserId == userId).ToListAsync();
        }

        public async Task<IEnumerable<Review>> GetByUserId(int userId)
        {
            return await _dbSet.Where(r => r.UserId == userId).ToListAsync();
        }

        public async Task<ReviewResultDto> GetReviewResult(string referenceMonth, string referenceYear)
        {
            var reviews = await _dbSet
                .Where(r => r.ReferenceMonth == referenceMonth && r.ReferenceYear == referenceYear)
                .ToListAsync();
            return new ReviewResultDto(reviews);
        }

        public async Task<IEnumerable<Review>> AddReviews(IEnumerable<Review> reviews)
        {
            await _dbSet.AddRangeAsync(reviews);
            await _context.SaveChangesAsync();
            return reviews;
        }
    }
}
