
using LearningApp.Business.Dtos;
using LearningApp.Business.Interfaces;
using LearningApp.Data.Entities;
using LearningApp.Data.Interfaces;

namespace LearningApp.Business.Services
{
    public class InstructorService : IInstructorService
    {
        private readonly IInstructorRepository repository;

        public InstructorService(IInstructorRepository repository)
        {
            this.repository = repository;
        }

        public CourseDto CreateCourse(CreateCourseDto dto)
        {
            var course = this.repository.CreateCourse(new Data.Entities.Course
            {
                Description = dto.Description,
                ImageUrl = dto.ImageUrl,
                InstructorId = dto.InstructorId,
                Price = dto.Price,
                Title = dto.Title,

            });
            return new CourseDto
            {
                Id = course.Id,
                Description = course.Description,
                ImageUrl = course.ImageUrl,
                InstructorId = course.InstructorId,
                Price = course.Price,
                Title = course.Title,
            };
        }

        public List<CourseDto> GetInstructorCourses(int instructorId)
        {
            var list = this.repository.GetInstructorCourses(instructorId);

            var result = list.Select(x => new CourseDto { Id = x.Id, Description = x.Description, ImageUrl = x.ImageUrl, InstructorId = x.InstructorId, Price = x.Price, Title = x.Title }).ToList();

            return result;
        }
    }
}