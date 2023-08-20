using desafio_4devs_domain.Models;
using MediatR;

namespace desafio_4devs.UseCasses.Users.Add
{
    public class UsersAddCommand : IRequest<UsersAddResponse>
    {
        public required string Name { get; set; }
        public required string Email { get; set; }
        // Password should be encrypted
        public required string Password { get; set; }

        public static implicit operator User(UsersAddCommand command)
        {
            // Hash and salt the password using bcrypt before storing it
            var hashedPassword = BCrypt.Net.BCrypt.HashPassword(command.Password);

            return new User
            {
                Name = command.Name,
                Email = command.Email,
                Password = hashedPassword,
                CreatedAt = DateTime.Now
            };
        }
    }
}
