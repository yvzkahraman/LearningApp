using LearningApp.Business.Dtos;
using LearningApp.Business.Interfaces;
using LearningApp.Data.Interfaces;

namespace LearningApp.Business.Services
{
    public class CourseService : ICourseService
    {
        private readonly ICourseRepository courseRepository;

        public CourseService(ICourseRepository courseRepository)
        {
            this.courseRepository = courseRepository;
        }

        public List<CourseDto> GetCourses()
        {
            var courses = this.courseRepository.GetCourses();

            var result = courses.Select(x => new CourseDto
            {
                Id = x.Id,
                Description = x.Description,
                ImageUrl = x.ImageUrl,
                InstructorId = x.InstructorId,
                Price = x.Price,
                Title = x.Title,
            }).ToList();

            return result;
        }

        public UserCoursesDto? GetMyCourses(string username)
        {
            var result = this.courseRepository.GetMyCourses(username);
            if (result != null)
            {

                var courses = result.Courses.Select(x => new CourseDto
                {
                    Description = x.Description,
                    Id = x.Id,
                    ImageUrl = x.ImageUrl,
                    InstructorId = x.InstructorId,
                    Price = x.Price,
                    Title = x.Title

                }).ToList();

                var user = new UserDto
                {
                    Id = result.User.Id,
                    Fullname = result.User.FullName,
                    Username = result.User.Username,
                };

                return new UserCoursesDto
                {
                    Courses = courses,
                    User = user,
                };
            }

            return null;
        }
    }
}