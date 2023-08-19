using MediatR;

namespace desafio_4devs.UseCasses.Users.Get
{
    public class UsersGetQuery : IRequest<IEnumerable<UsersGetResponse>>
    {
    }
}
