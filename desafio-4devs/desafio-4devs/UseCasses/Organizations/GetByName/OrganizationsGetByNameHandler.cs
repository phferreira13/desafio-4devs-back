using desafio_4devs_domain.Interfaces.Repostirories;
using MediatR;

namespace desafio_4devs.UseCasses.Organizations.GetByName
{
    public class OrganizationsGetByNameHandler : OrganizationsBaseHandler, IRequestHandler<OrganizationsGetByNameQuery, OrganizationsGetByNameResponse>
    {
        public OrganizationsGetByNameHandler(IOrganizationRepository organizationRepository) : base(organizationRepository)
        {
        }

        public async Task<OrganizationsGetByNameResponse> Handle(OrganizationsGetByNameQuery request, CancellationToken cancellationToken)
        {
            var list = await organizationRepository.GetByName(request.Name);
            return new OrganizationsGetByNameResponse { Organizations = list.ConvertAll<OrganizationsResponse>(organization => organization) };
        }
    }
}
