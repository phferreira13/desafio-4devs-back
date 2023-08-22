using desafio_4devs_domain.Interfaces.Repostirories;
using MediatR;

namespace desafio_4devs.UseCasses.Users.Login
{
    public class UsersLoginHandler : UsersBaseHandler, IRequestHandler<UsersLoginCommand, UsersLoginResponse>
    {
        public UsersLoginHandler(IUserRepository userRepository) : base(userRepository)
        {
        }

        public async Task<UsersLoginResponse> Handle(UsersLoginCommand request, CancellationToken cancellationToken)
        {
            var user = await userRepository.Get(request.Email, request.Password);
            return user;
        }
    }
}
