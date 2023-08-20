using desafio_4devs_domain.Interfaces.Repostirories;

namespace desafio_4devs.UseCasses.Organizations
{
    public abstract class OrganizationsBaseHandler
    {
        protected readonly IOrganizationRepository organizationRepository;

        public OrganizationsBaseHandler(IOrganizationRepository organizationRepository)
        {
            this.organizationRepository = organizationRepository;
        }
    }
}
