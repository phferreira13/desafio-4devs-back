using desafio_4devs_domain.Exceptions;
using desafio_4devs_domain.Extensions;
using desafio_4devs_domain.Interfaces.Repostirories;
using desafio_4devs_domain.Models;
using desafio_4devs_entity.Context;
using desafio_4devs_entity.Repositories.Base;
using Microsoft.EntityFrameworkCore;

namespace desafio_4devs_entity.Repositories
{
    public class OrganizationRepository : BaseCrudRepository<Organization>, IOrganizationRepository
    {
        public OrganizationRepository(App4DevsContext context) : base(context)
        {
        }

        public override async Task<Organization> Create(Organization organization)
        {
            if(await _dbSet.AnyAsync(o => o.Cnpj == organization.Cnpj))
                throw new Exception(EOrganizationExceptions.OrganizationAlreadyExists.GetDescription());

            organization.CreatedAt = DateTime.Now;
            await _dbSet.AddAsync(organization);
            await _context.SaveChangesAsync();
            return organization;
        }

        public async Task<List<Organization>> GetByName(string name)
        {
            return await _dbSet
                .Include(o => o.Reviews)
                .Where(o => o.Name.ToLower().Contains(name.ToLower()))
                .ToListAsync();
        }
    }
}
