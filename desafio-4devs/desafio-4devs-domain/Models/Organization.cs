using desafio_4devs_domain.Models.Base;

namespace desafio_4devs_domain.Models
{
    public class Organization : BaseEntityModel
    {
        public required string Name { get; set; }
        public required string ContactName { get; set; }
        public string? Cnpj { get; set; }
    }
}
