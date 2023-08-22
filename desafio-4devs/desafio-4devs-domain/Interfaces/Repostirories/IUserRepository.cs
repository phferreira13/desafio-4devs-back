using desafio_4devs_domain.Interfaces.Repostirories.Base;
using desafio_4devs_domain.Models;

namespace desafio_4devs_domain.Interfaces.Repostirories
{
    public interface IUserRepository : IBaseCrudRepository<User>
    {
        Task<User?> Get(string email);
        Task<User?> Get(string email, string password);
    }
}
