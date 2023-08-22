using desafio_4devs_domain.Models;
using MediatR;

namespace desafio_4devs.UseCasses.Users.Add
{
    public class UsersAddCommand : IRequest<UsersAddResponse>
    {
        public required string Name { get; set; }
        public required string Email { get; set; }
        public required string Password { get; set; }

        public static implicit operator User(UsersAddCommand command)
        {

            return new User
            {
                Name = command.Name,
                Email = command.Email,
                Password = command.Password,
                CreatedAt = DateTime.Now
            };
        }
    }
}
