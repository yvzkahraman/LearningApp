namespace LearningApp.Data.Entities
{
    public class Course
    {
        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public string Description { get; set; } = null!;

        public string? ImageUrl { get; set; }

        public decimal Price { get; set; }


        public int InstructorId { get; set; }

        public AppUser? Instructor { get; set; }

        public List<AppUserCourse>? AppUserCourses { get; set; }

        public List<Review>? Reviews { get; set; }
    }
}
