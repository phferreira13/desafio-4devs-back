using desafio_4devs_domain.Models;

namespace desafio_4devs.UseCasses.Organizations.Add
{
    public class OrganizationsAddResponse : OrganizationsBaseResponse
    {
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }

        public static implicit operator OrganizationsAddResponse(Organization entity)
        {
            return new OrganizationsAddResponse
            {
                Id = entity.Id,
                Name = entity.Name,
                ContactName = entity.ContactName,
                Cnpj = entity.Cnpj,
                CreatedAt = entity.CreatedAt
            };
        }
    }
}
