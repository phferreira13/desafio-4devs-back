using desafio_4devs_domain.Exceptions;
using desafio_4devs_domain.Extensions;
using desafio_4devs_domain.Interfaces.Repostirories.Base;
using desafio_4devs_domain.Models;
using desafio_4devs_domain.Models.Base;
using desafio_4devs_entity.Context;
using Microsoft.EntityFrameworkCore;

namespace desafio_4devs_entity.Repositories.Base
{
    public abstract class BaseCrudRepository<T> : IBaseCrudRepository<T> where T : BaseEntityModel
    {
        protected readonly App4DevsContext _context;
        protected readonly DbSet<T> _dbSet;

        public BaseCrudRepository(App4DevsContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }

        public virtual async Task<T> Create(T entity)
        {
            entity.CreatedAt = DateTime.Now;
            await _dbSet.AddAsync(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public virtual async Task<T> Delete(T entity)
        {
            _dbSet.Remove(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public virtual async Task<T> Get(int id)
        {
            var result = await _dbSet.FirstOrDefaultAsync(u => u.Id == id);
            return result ?? throw new Exception(EEntityExceptions.EntityNotFound.GetDescription());
        }

        public virtual async Task<List<T>> Get()
        {
            return await _dbSet.ToListAsync();
        }

        public virtual async Task<T> Update(T entity)
        {
            var entityDb = _dbSet.FirstOrDefault(u => u.Id == entity.Id);
            if (entityDb == null) throw new Exception(EEntityExceptions.EntityNotFound.GetDescription());
            entityDb.UpdatedAt = DateTime.Now;
            _dbSet.Update(entityDb);
            await _context.SaveChangesAsync();
            return entityDb;
        }
    }
}
