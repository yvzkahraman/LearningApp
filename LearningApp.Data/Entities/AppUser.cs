using LearningApp.Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningApp.Data.Entities
{
    public class AppUser
    {
        public int Id { get; set; }
        public string FullName { get; set; } = null!;

        public string Username { get; set; } = null!;

        public string Password { get; set; } = null!;

        public UserType UserType { get; set; }

        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;

        public List<AppUserCourse>? AppUserCourses { get; set; }

        public List<Course>? Courses { get; set; }
    }
}
