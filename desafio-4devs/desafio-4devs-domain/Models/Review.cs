using desafio_4devs_domain.Models.Base;

namespace desafio_4devs_domain.Models
{
    public class Review : BaseEntityModel
    {
        public required string ReferenceMonth { get; set; }
        public required string ReferenceYear { get; set; }
        public required int Rating { get; set; }
        public required string Comment { get; set; }
        public required int OrganizationId { get; set; }
        public required int UserId { get; set; }
        public Organization? Organization { get; set; }
        public User? User { get; set; }
        

    }
}
