using desafio_4devs_domain.Exceptions;
using desafio_4devs_domain.Extensions;
using desafio_4devs_domain.Interfaces.Repostirories;
using desafio_4devs_domain.Models;
using desafio_4devs_entity.Context;
using desafio_4devs_entity.Repositories.Base;
using Microsoft.EntityFrameworkCore;

namespace desafio_4devs_entity.Repositories
{
    public class UserRepository : BaseCrudRepository<User>, IUserRepository
    {
        
        public UserRepository(App4DevsContext context) : base(context)
        {
        }

        public async Task<User?> Get(string email)
        {
            var result = await _dbSet
                .Include(o => o.Reviews)
                .FirstOrDefaultAsync(u => u.Email == email);
            return result;
        }

        public new async Task<User> Update(User user)
        {
            var userDb = _dbSet.FirstOrDefault(u => u.Id == user.Id);
            if (userDb == null) throw new Exception(EUserException.UserNotFound.GetDescription());
            userDb.Name = user.Name;
            userDb.Email = user.Email;
            userDb.Password = user.Password;
            userDb.UpdatedAt = DateTime.Now;
            _dbSet.Update(userDb);
            await _context.SaveChangesAsync();
            return userDb;
        }
    }
}
