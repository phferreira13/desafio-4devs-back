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
        private readonly App4DevsContext _context;
        private readonly DbSet<User> _dbSet;
        
        public UserRepository(App4DevsContext context) : base(context)
        {
            _context = context;
            _dbSet = _context.Set<User>();
        }

        public async Task<User> Get(string email)
        {
            var result = await _dbSet.FirstOrDefaultAsync(u => u.Email == email);
            return result ?? throw new Exception(EUserException.UserNotGettedByEmail.GetDescription());
        }

        public new async Task<User> Update(User user)
        {
            var userDb = _dbSet.FirstOrDefault(u => u.Id == user.Id);
            if (userDb == null) throw new Exception("Usuário não encontrado.");
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
