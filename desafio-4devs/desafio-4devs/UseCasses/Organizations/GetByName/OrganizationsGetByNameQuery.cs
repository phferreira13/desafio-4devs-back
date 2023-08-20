using MediatR;

namespace desafio_4devs.UseCasses.Organizations.GetByName
{
    public class OrganizationsGetByNameQuery : IRequest<OrganizationsGetByNameResponse>
    {
        public required string Name { get; set; }
    }
}
