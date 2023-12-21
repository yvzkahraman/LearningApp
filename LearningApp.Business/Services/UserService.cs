using LearningApp.Business.Dtos;
using LearningApp.Business.Interfaces;
using LearningApp.Data.Contexts;
using LearningApp.Data.Enums;
using LearningApp.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningApp.Business.Services
{
    public class UserService : IUserService
    {
        private readonly LearningContext context;

        public UserService(LearningContext context)
        {
            this.context = context;
        }

        public UserDto RegisterUser(RegisterDto dto)
        {
           var createdUser =  new UserRepository(context).AddUser(new Data.Entities.AppUser
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
    }
}
