using LearningApp.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningApp.Data.Configuraitons
{
    public class AppUserConfiguration : IEntityTypeConfiguration<AppUser>
    {
        public void Configure(EntityTypeBuilder<AppUser> builder)
        {
            builder.HasMany(x => x.Courses).WithOne(x => x.Instructor).OnDelete(DeleteBehavior.NoAction);

            builder.HasMany(x=>x.AppUserCourses).WithOne(x=>x.AppUser).OnDelete(DeleteBehavior.NoAction);
        }
    }
}
