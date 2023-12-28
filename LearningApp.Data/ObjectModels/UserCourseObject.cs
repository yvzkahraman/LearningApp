using LearningApp.Data.Entities;

namespace LearningApp.Data.ObjectModels{
    public class UserCourseObject{
        public AppUser User { get; set; } = null!;

        public List<Course> Courses { get; set; } = null!;
    }
}