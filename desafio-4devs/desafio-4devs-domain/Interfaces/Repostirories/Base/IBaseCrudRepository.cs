using desafio_4devs_domain.Models.Base;

namespace desafio_4devs_domain.Interfaces.Repostirories.Base
{
    public interface IBaseCrudRepository <T> where T : BaseEntityModel
    {
        Task<T> Create(T entity);
        Task<T> Update(T entity);
        Task<T> Delete(T entity);
        Task<T> Get(int id);
        Task<List<T>> Get();
    }
}
