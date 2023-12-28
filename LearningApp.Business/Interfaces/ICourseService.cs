using LearningApp.Business.Dtos;

namespace LearningApp.Business.Interfaces
{
    public interface ICourseService
    {
        List<CourseDto> GetCourses();

        UserCoursesDto? GetMyCourses(string username);
    }
}