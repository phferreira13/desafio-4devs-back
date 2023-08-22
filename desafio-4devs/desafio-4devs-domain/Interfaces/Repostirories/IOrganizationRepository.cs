using desafio_4devs_domain.Interfaces.Repostirories.Base;
using desafio_4devs_domain.Models;

namespace desafio_4devs_domain.Interfaces.Repostirories
{
    public interface IOrganizationRepository : IBaseCrudRepository<Organization>
    {
        Task<List<Organization>> GetByName(string name);
        Task<List<Organization>> GetOrganizationsWithReviews();
    }
}
