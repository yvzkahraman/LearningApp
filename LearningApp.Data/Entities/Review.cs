using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningApp.Data.Entities
{
    public class Review
    {
        public int Id { get; set; }

        public string? Description { get; set; }

        public int Rating { get; set; }

        public int CourseId { get; set; }

        public Course? Course { get; set; }
    }
}
