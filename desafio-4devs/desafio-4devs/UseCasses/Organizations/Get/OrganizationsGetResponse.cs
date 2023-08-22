using desafio_4devs_domain.Models;

namespace desafio_4devs.UseCasses.Organizations.Get
{
    public class OrganizationsGetResponse
    {
        public required IEnumerable<OrganizationResponse> Organizations { get; set; }
    }

    public class OrganizationResponse : OrganizationsBaseResponse
    {
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

        public static implicit operator OrganizationResponse(Organization organization)
        {
            return new OrganizationResponse
            {
                Id = organization.Id,
                Name = organization.Name,
                ContactName = organization.ContactName,
                Cnpj = organization.Cnpj,
                CreatedAt = organization.CreatedAt,
                UpdatedAt = organization.UpdatedAt,
                Reviews = organization.Reviews?.ToList().ConvertAll<OrganizationReviewBaseResponse>(r => r)
            };
        }
    }
}
