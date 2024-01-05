using LearningApp.Business.Dtos;

namespace LearningApp.Business.Interfaces
{
    public interface IStudentService
    {
        void AssignCourse(AssignCourseDto dto);
    }
}