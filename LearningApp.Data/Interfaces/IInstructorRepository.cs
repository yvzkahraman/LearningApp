using LearningApp.Data.Entities;

namespace LearningApp.Data.Interfaces
{
    // theme | tailwind.css 
    public interface IInstructorRepository
    {
       List<Course> GetInstructorCourses(int instructorId);

         Course CreateCourse(Course course);


    }
}