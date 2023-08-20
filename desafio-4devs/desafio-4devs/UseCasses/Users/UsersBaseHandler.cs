using desafio_4devs_domain.Interfaces.Repostirories;

namespace desafio_4devs.UseCasses.Users
{
    public abstract class UsersBaseHandler
    {
        protected readonly IUserRepository userRepository;

        public UsersBaseHandler(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }
    }
}
