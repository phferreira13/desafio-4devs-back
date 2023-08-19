using desafio_4devs_domain.Interfaces.Repostirories;
using MediatR;

namespace desafio_4devs.UseCasses.Users.Add
{
    public class UsersAddHandler : UsersBaseHandler, IRequestHandler<UsersAddCommand, UsersAddResponse>
    {
        public UsersAddHandler(IUserRepository userRepository) : base(userRepository)
        {
        }

        public async Task<UsersAddResponse> Handle(UsersAddCommand request, CancellationToken cancellationToken)
        {
            var user = await userRepository.Create(request);

            return user;
        }
    }
}
