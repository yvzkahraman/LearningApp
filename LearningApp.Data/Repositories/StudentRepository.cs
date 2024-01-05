using System.Linq.Expressions;
using LearningApp.Data.Contexts;
using LearningApp.Data.Entities;
using LearningApp.Data.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace LearningApp.Data.Repositories
{
    public class StudentRepository : IStudentRepository
    {
        private readonly LearningContext context;

        public StudentRepository(LearningContext context)
        {
            this.context = context;
        }

        public AppUserCourse AssignCourse(AppUserCourse appUserCourse)
        {
            this.context.AppUserCourses.Add(appUserCourse);
            this.context.SaveChanges();
            return appUserCourse;
        }

        public AppUserCourse? CheckCourse(Expression<Func<AppUserCourse,bool>> filter){
            return this.context.AppUserCourses.AsNoTracking().SingleOrDefault(filter);
        }
    }
}