using desafio_4devs_domain.Interfaces.Repostirories;
using MediatR;

namespace desafio_4devs.UseCasses.Organizations.Add
{
    public class OrganizationsAddHandler : OrganizationsBaseHandler, IRequestHandler<OrganizationsAddCommand, OrganizationsAddResponse>
    {
        public OrganizationsAddHandler(IOrganizationRepository repository) : base(repository)
        {
        }

        public async Task<OrganizationsAddResponse> Handle(OrganizationsAddCommand request, CancellationToken cancellationToken)
        {
            var organization = await organizationRepository.Create(request);

            return organization;
        }
    }
}
