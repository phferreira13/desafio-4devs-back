using desafio_4devs_domain.Interfaces.Repostirories;
using MediatR;

namespace desafio_4devs.UseCasses.Organizations.Get
{
    public class OrganizationsGetHandler : OrganizationsBaseHandler, IRequestHandler<OrganizationsGetQuery, OrganizationsGetResponse>
    {
        public OrganizationsGetHandler(IOrganizationRepository organizationRepository) : base(organizationRepository)
        {
        }

        public async Task<OrganizationsGetResponse> Handle(OrganizationsGetQuery request, CancellationToken cancellationToken)
        {
            var list = await organizationRepository.Get();
            return new OrganizationsGetResponse { Organizations = list.ConvertAll<OrganizationResponse>(organization => organization) };
        }
    }
}
