

using LearningApp.Business.Dtos;

namespace LearningApp.Business.Interfaces
{

    public interface IInstructorService
    {
        List<CourseDto> GetInstructorCourses(int instructorId);
        CourseDto CreateCourse(CreateCourseDto dto);

    }

}