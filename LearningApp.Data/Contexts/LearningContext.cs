using LearningApp.Data.Configuraitons;
using LearningApp.Data.Entities;
using Microsoft.EntityFrameworkCore;


namespace LearningApp.Data.Contexts
{
    public class LearningContext : DbContext
    {
        public LearningContext(DbContextOptions<LearningContext> options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AppUserConfiguration());

            modelBuilder.Entity<Course>().Property(x=>x.Price).HasPrecision(18,2);

            
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<AppUser> AppUsers { get; set; }

        public DbSet<Course> Courses { get; set; }
        public DbSet<AppUserCourse> AppUserCourses { get; set; }

        public DbSet<Review> Reviews { get; set; }
    }
}
