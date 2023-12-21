using LearningApp.Business.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningApp.Business.Interfaces
{
    public interface IUserService
    {
        UserDto RegisterUser(RegisterDto dto);
    }
}
