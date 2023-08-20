
namespace desafio_4devs_domain.Models.Base
{
    public abstract class BaseEntityModel
    {
        public virtual int Id { get; set; }
        public virtual DateTime CreatedAt { get; set;}
        public virtual DateTime? UpdatedAt { get; set; }
    }
}
