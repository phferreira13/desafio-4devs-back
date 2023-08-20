namespace desafio_4devs.UseCasses.Users
{
    public abstract class UsersBaseResponse
    {
        public required string Name { get; set; }
        public required string Email { get; set; }
        public required string Password { get; set; }
    }
}
