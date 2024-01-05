namespace LearningApp.Business{

    public class AssignCourseDto{
        public int StudentId { get; set; }

        public List<CourseIdDto> Courses { get; set; } = null!;
    } 

    public class CourseIdDto{
        public int Id { get; set; }
    }
}