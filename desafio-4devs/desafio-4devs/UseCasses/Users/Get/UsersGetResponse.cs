using desafio_4devs_domain.Models;

namespace desafio_4devs.UseCasses.Users.Get
{
    public class UsersGetResponse
    {
        public required IEnumerable<UserResponse> Users { get; set; }
    }

    public class UserResponse : UsersBaseResponse
    {
        public int Id { get; set; }

        public static implicit operator UserResponse(User user)
        {
            return new UserResponse
            {
                Id = user.Id,
                Name = user.Name,
                Email = user.Email,
                Password = user.Password
            };
        }
    }
}
