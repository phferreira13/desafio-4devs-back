using desafio_4devs_domain.Models;

namespace desafio_4devs.UseCasses.Organizations.GetByName
{
    public class OrganizationsGetByNameResponse
    {
        public required IEnumerable<OrganizationsResponse> Organizations { get; set; }
    }

    public class OrganizationsResponse : OrganizationsBaseResponse
    {
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

        public static implicit operator OrganizationsResponse(Organization organization)
        {
            return new OrganizationsResponse
            {
                Id = organization.Id,
                Name = organization.Name,
                ContactName = organization.ContactName,
                Cnpj = organization.Cnpj,
                CreatedAt = organization.CreatedAt,
                UpdatedAt = organization.UpdatedAt
            };
        }
    }
}
