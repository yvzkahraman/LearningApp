using System.Linq.Expressions;
using LearningApp.Data.Entities;

namespace LearningApp.Data.Interfaces
{
    public interface IStudentRepository
    {
        AppUserCourse AssignCourse(AppUserCourse appUserCourse);
        AppUserCourse? CheckCourse(Expression<Func<AppUserCourse, bool>> filter);
    }
}