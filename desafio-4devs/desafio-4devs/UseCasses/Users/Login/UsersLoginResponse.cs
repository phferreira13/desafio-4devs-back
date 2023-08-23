using desafio_4devs.UseCasses.Users.Get;
using desafio_4devs_domain.Models;

namespace desafio_4devs.UseCasses.Users.Login
{
    public class UsersLoginResponse
    {
        public UserResponse? User { get; set; }
        public string? Token { get; set; }
    }

    public class UsersResponse : UsersBaseResponse
    {
        public int Id { get; set; }

        public static implicit operator UsersResponse(User? user)
        {
            if (user == null)
                return null;
            return new UsersResponse
            {
                Id = user.Id,
                Name = user.Name,
                Email = user.Email,
                Password = user.Password
            };
        }
    }
}
