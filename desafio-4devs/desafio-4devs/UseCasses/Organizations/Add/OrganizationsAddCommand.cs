using desafio_4devs_domain.Models;
using MediatR;

namespace desafio_4devs.UseCasses.Organizations.Add
{
    public class OrganizationsAddCommand : IRequest<OrganizationsAddResponse>
    {
        public required string Name { get; set; }
        public required string ContactName { get; set; }
        public string? Cnpj { get; set; }

        public static implicit operator Organization(OrganizationsAddCommand command)
        {
            return new Organization
            {
                Name = command.Name,
                ContactName = command.ContactName,
                Cnpj = command.Cnpj
            };
        }
    }
}
