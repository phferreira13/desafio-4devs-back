using desafio_4devs_domain.Interfaces.Repostirories;
using MediatR;

namespace desafio_4devs.UseCasses.Users.Get
{
    public class UsersGetHandler : UsersBaseHandler, IRequestHandler<UsersGetQuery, UsersGetResponse>
    {
        public UsersGetHandler(IUserRepository userRepository) : base(userRepository)
        {
        }

        public async Task<UsersGetResponse> Handle(UsersGetQuery request, CancellationToken cancellationToken)
        {
            var users = await userRepository.Get();
            return new UsersGetResponse { Users = users.ConvertAll<UserResponse>(user => user) };
        }
    }
}
