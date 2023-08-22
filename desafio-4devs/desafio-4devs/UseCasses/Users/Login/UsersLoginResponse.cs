using desafio_4devs_domain.Models;

namespace desafio_4devs.UseCasses.Users.Login
{
    public class UsersLoginResponse : UsersBaseResponse
    {
        public int Id { get; set; }

        public static implicit operator UsersLoginResponse(User? user)
        {
            if (user == null)
                return null;
            return new UsersLoginResponse
            {
                Id = user.Id,
                Name = user.Name,
                Email = user.Email,
                Password = user.Password
            };
        }
    }
}
