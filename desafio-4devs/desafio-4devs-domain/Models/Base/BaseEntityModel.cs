
namespace desafio_4devs_domain.Models.Base
{
    public abstract class BaseEntityModel
    {
        public int Id { get; set; }
        public DateTime CreatedAt { get; set;}
        public DateTime? UpdatedAt { get; set; }
    }
}
