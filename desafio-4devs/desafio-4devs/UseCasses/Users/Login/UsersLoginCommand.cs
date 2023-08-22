using MediatR;

namespace desafio_4devs.UseCasses.Users.Login
{
    public class UsersLoginCommand : IRequest<UsersLoginResponse>
    {
        public required string Email { get; set; }
        public required string Password { get; set; }

    }
}
