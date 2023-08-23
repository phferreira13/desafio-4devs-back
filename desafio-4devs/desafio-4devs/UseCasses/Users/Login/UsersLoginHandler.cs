using desafio_4devs_domain.Interfaces.Repostirories;
using desafio_4devs_domain.Models;
using MediatR;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace desafio_4devs.UseCasses.Users.Login
{
    public class UsersLoginHandler : UsersBaseHandler, IRequestHandler<UsersLoginCommand, UsersLoginResponse>
    {
        private readonly IConfiguration _configuration;
        public UsersLoginHandler(IUserRepository userRepository, IConfiguration configuration) : base(userRepository)
        {
            _configuration = configuration;
        }

        public async Task<UsersLoginResponse> Handle(UsersLoginCommand request, CancellationToken cancellationToken)
        {
            var user = await userRepository.Get(request.Email, request.Password);
            if (user == null)
                return new UsersLoginResponse();

            var response = new UsersLoginResponse { User = user };
            response.Token = GenerateJwtToken(user);

            return response;
        }

        private string GenerateJwtToken(User user)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_configuration["JwtSettings:Secret"]);

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new[]
                {
                    new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
                    new Claim(ClaimTypes.Name, user.Name),
                    new Claim(ClaimTypes.Email, user.Email)
                }),
                Expires = DateTime.UtcNow.AddHours(1),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };

            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }
    }
}
