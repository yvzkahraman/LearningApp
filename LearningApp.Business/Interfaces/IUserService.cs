using LearningApp.Business.Dtos;

namespace LearningApp.Business.Interfaces
{
    public interface IUserService
    {
        UserDto RegisterUser(RegisterDto dto);

        TokenDto? CheckUser(LoginDto dto);
    }
}
