using desafio_4devs_domain.Models;

namespace desafio_4devs.UseCasses.Users.Add
{
    public class UsersAddResponse : UsersBaseResponse
    {
        public int Id { get; set; }

        public static implicit operator UsersAddResponse(User user)
        {
            return new UsersAddResponse
            {
                Id = user.Id,
                Name = user.Name,
                Email = user.Email,
                Password = user.Password
            };
        }
    }
}
