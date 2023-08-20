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
        private readonly App4DevsContext _context;
        private readonly DbSet<Organization> _dbSet;
        public OrganizationRepository(App4DevsContext context) : base(context)
        {
            _context = context;
            _dbSet = _context.Set<Organization>();
        }

        public new async Task<Organization> Create(Organization organization)
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
                .Where(o => o.Name.ToLower().Contains(name.ToLower()))
                .ToListAsync();
        }
    }
}
