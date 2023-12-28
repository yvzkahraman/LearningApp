using LearningApp.Data.Contexts;
using LearningApp.Data.Entities;
using LearningApp.Data.Interfaces;
using LearningApp.Data.ObjectModels;
using Microsoft.EntityFrameworkCore;

namespace LearningApp.Data.Repositories
{
    public class CourseRepository : ICourseRepository
    {
        private readonly LearningContext context;

        public CourseRepository(LearningContext context)
        {
            this.context = context;
        }

        public List<Course> GetCourses()
        {

            return this.context.Courses.AsNoTracking().ToList();
        }

        public UserCourseObject? GetMyCourses(string username)
        {
            var user = this.context.AppUsers.SingleOrDefault(x => x.Username == username);
            if (user != null)
            {
                var courses = this.context.Courses.Join(this.context.AppUserCourses, course => course.Id, userCourse => userCourse.CourseId, (course, userCourse) => new
                {
                    course,
                    userCourse
                }).Where(x => x.userCourse.AppUserId == user.Id).Select(twoTable => new Course
                {
                    Id = twoTable.course.Id,
                    Description = twoTable.course.Description,
                    ImageUrl = twoTable.course.ImageUrl,
                    InstructorId = twoTable.course.InstructorId,
                    Price = twoTable.course.Price,
                    Title = twoTable.course.Title,
                }).AsNoTracking().ToList();

                return new UserCourseObject{
                    Courses = courses,
                    User = user,
                };
            }
            return null;
        }
    }
}