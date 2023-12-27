using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using LearningApp.Business.Defaults;
using LearningApp.Business.Dtos;
using LearningApp.Business.Interfaces;
using LearningApp.Data.Enums;
using LearningApp.Data.Interfaces;
using Microsoft.AspNetCore.Authorization.Infrastructure;
using Microsoft.IdentityModel.Tokens;

namespace LearningApp.Business.Services
{
    public class UserService : IUserService
    {

        private readonly IUserRepository userRepository;

        public UserService(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }

        public UserDto RegisterUser(RegisterDto dto)
        {
            var createdUser = this.userRepository.AddUser(new Data.Entities.AppUser
            {
                CreatedDate = DateTime.Now,
                FullName = dto.FullName,
                Password = dto.Password,
                Username = dto.Username,
                UserType = (UserType)dto.UserType
            });


            return new UserDto
            {
                Id = createdUser.Id,
                Fullname = createdUser.FullName,
                Username = createdUser.Username,
            };
        }

        public TokenDto? CheckUser(LoginDto dto)
        {
            var user = this.userRepository.GetUser(x => x.Username == dto.Username && x.Password == dto.Password);
            if (user != null)
            {
                var expiredTokenDate = DateTime.UtcNow.AddMinutes(TokenDefaults.Expire);

                var claims = new List<Claim>{
                    new Claim(ClaimTypes.Role, user.UserType.ToString()),
                    new Claim("FullName",user.FullName),
                    new Claim("Username",user.Username),
                };

                var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(TokenDefaults.Key));

                var signingCredentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);


                var securityToken = new JwtSecurityToken(issuer: TokenDefaults.Issuer, audience: TokenDefaults.Audience, claims: claims, notBefore: DateTime.UtcNow, expires: expiredTokenDate, signingCredentials: signingCredentials);

                JwtSecurityTokenHandler handler = new JwtSecurityTokenHandler();

                var token = handler.WriteToken(securityToken);

                return new TokenDto()
                {
                    Expire = DateTime.UtcNow.AddMinutes(TokenDefaults.Expire),
                    Token = token,
                };
            }

            return null;
        }
    }
}
