using LearningApp.Business.Dtos;
using LearningApp.Business.Interfaces;
using LearningApp.Data.Enums;
using LearningApp.Data.Interfaces;

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

        public TokenDto? CheckUser(LoginDto dto){
            var user = this.userRepository.GetUser(x=>x.Username == dto.Username && x.Password == dto.Password);
            if(user!=null){
                return new TokenDto(){
                    FullName = user.FullName,
                    Username= user.Username,
                };
            }
            return null;
        }
    }
}
