using System.ComponentModel;

namespace desafio_4devs_domain.Exceptions
{
    public enum EOrganizationExceptions
    {
        [Description("Cliente não encontrado")]
        OrganizationNotFound,
        [Description("Cliente com este CNPJ já existe")]
        OrganizationAlreadyExists,
        [Description("Cliente não pode ser excluído")]
        OrganizationCannotBeDeleted,
    }
}
