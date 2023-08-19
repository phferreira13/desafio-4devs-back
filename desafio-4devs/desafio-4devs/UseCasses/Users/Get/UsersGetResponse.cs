using desafio_4devs_domain.Models;

namespace desafio_4devs.UseCasses.Users.Get
{
    public class UsersGetResponse : UsersBaseResponse
    {
        public int Id { get; set; }

        public static implicit operator UsersGetResponse(User user)
        {
            return new UsersGetResponse
            {
                Id = user.Id,
                Name = user.Name,
                Email = user.Email,
                Password = user.Password
            };
        }
    }
}
