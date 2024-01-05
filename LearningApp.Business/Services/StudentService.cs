using LearningApp.Business.Dtos;
using LearningApp.Business.Interfaces;
using LearningApp.Data.Interfaces;

namespace LearningApp.Business.Services
{
    public class StudentService : IStudentService
    {
        private readonly IStudentRepository studentRepository;

        public StudentService(IStudentRepository studentRepository)
        {
            this.studentRepository = studentRepository;
        }

        public void AssignCourse(AssignCourseDto dto)
        {
            foreach (var course in dto.Courses)
            {
                var existCourse = this.studentRepository.CheckCourse(x => x.CourseId == course.Id && x.AppUserId == dto.StudentId);

                if (existCourse == null)
                {
                    this.studentRepository.AssignCourse(new Data.Entities.AppUserCourse
                    {
                        AppUserId = dto.StudentId,
                        CourseId = course.Id,
                    });

                }


            }

        }
    }
}