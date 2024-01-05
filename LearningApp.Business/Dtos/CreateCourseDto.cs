namespace LearningApp.Business.Dtos
{
    public class CreateCourseDto
    {
        public string Title { get; set; } = null!;
        public string Description { get; set; } = null!;

        public string? ImageUrl { get; set; }

        public decimal Price { get; set; }


        public int InstructorId { get; set; }
    }
}