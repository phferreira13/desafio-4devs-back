using desafio_4devs_domain.Interfaces.Repostirories;
using MediatR;

namespace desafio_4devs.UseCasses.Users.Get
{
    public class UsersGetHandler : UsersBaseHandler, IRequestHandler<UsersGetQuery, IEnumerable<UsersGetResponse>>
    {
        public UsersGetHandler(IUserRepository userRepository) : base(userRepository)
        {
        }

        public async Task<IEnumerable<UsersGetResponse>> Handle(UsersGetQuery request, CancellationToken cancellationToken)
        {
            var users = await userRepository.Get();
            return users.ConvertAll<UsersGetResponse>(user => user);
        }
    }
}
