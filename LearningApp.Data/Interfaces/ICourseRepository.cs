using LearningApp.Data.Entities;
using LearningApp.Data.ObjectModels;

namespace LearningApp.Data.Interfaces
{
    public interface ICourseRepository
    {
        List<Course> GetCourses();

        UserCourseObject? GetMyCourses(string username);
    }
}