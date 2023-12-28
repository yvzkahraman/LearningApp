namespace LearningApp.Business.Dtos
{
    public class UserCoursesDto
    {
        public UserDto User  { get; set; } = null!;

        public List<CourseDto> Courses {get; set;} = null!;
    }
}