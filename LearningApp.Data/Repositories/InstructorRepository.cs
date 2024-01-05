using System.Runtime.CompilerServices;
using LearningApp.Data.Contexts;
using LearningApp.Data.Entities;
using LearningApp.Data.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace LearningApp.Data.Repositories
{
    public class InstructorRepository : IInstructorRepository
    {
        private readonly LearningContext context;

        public InstructorRepository(LearningContext context)
        {
            this.context = context;
        }

        public Course CreateCourse(Course course)
        {
            this.context.Courses.Add(course);
            this.context.SaveChanges();

            return course;
        }

        public List<Course> GetInstructorCourses(int instructorId)
        {
            var courses = this.context.Courses.Where(x => x.InstructorId == instructorId).AsNoTracking().ToList();
            return courses;
        }
    }
}

