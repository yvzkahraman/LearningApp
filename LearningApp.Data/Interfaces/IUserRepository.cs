using System.Linq.Expressions;
using LearningApp.Data.Entities;

namespace LearningApp.Data.Interfaces{

    public interface IUserRepository{
        AppUser AddUser(AppUser appUser);
        AppUser? GetUser(Expression<Func<AppUser,bool>> filter);
    }
}