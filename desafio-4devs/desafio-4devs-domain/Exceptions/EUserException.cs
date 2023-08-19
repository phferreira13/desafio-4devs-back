using System.ComponentModel;

namespace desafio_4devs_domain.Exceptions
{
    public enum EUserException
    {
        [Description("Usuário não encontrado")]
        UserNotFound,
        [Description("Usuário já existe")]
        UserAlreadyExists,
        [Description("Usuário não criado")]
        UserNotCreated,
        [Description("Usuário não atualizado")]
        UserNotUpdated,
        [Description("Usuário não deletado")]
        UserNotDeleted,
        [Description("Usuário não obtido")]
        UserNotGetted,
        [Description("Usuário não obtido por email")]
        UserNotGettedByEmail,
        [Description("Usuário não obtido por id")]
        UserNotGettedById,
        [Description("Nenhum usuário encontrado")]
        UserNotGettedAll
    }
}
