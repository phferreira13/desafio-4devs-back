using System.ComponentModel;

namespace desafio_4devs_domain.Exceptions
{
    public enum EEntityExceptions
    {
        [Description("Registro não encontrado")]
        EntityNotFound,
        [Description("Registro já existe")]
        EntityAlreadyExists,        
    }
}
