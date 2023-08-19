using desafio_4devs_domain.Models;

namespace desafio_4devs_domain.Interfaces.Repostirories
{
    public interface IUserRepository
    {
        Task<User> Create(User user);
        Task<User> Update(User user);
        Task<User> Delete(User user);
        Task<User> Get(int id);
        Task<List<User>> Get();
        Task<User> Get(string email);
    }
}
