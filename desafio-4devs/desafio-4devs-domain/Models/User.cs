using desafio_4devs_domain.Models.Base;

namespace desafio_4devs_domain.Models
{
    public class User : BaseEntityModel
    {
        public required string Name { get; set; }
        public required string Email { get; set; }
        public required string Password { get; set; }
        public IEnumerable<Review>? Reviews { get; set; }
    }
}
