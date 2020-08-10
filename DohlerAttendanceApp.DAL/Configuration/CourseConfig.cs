using System;
using System.Collections.Generic;
using System.Text;
using DohlerAttendanceApp.Core.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DohlerAttendanceApp.DAL.Configuration
{
    public class CourseConfig : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> builder)
        {
            builder.HasKey(o => o.Id);

            builder.Property(c => c.Duration).IsRequired();
            builder.Property(c => c.Name).IsRequired();
            builder.Property(c => c.Title).IsRequired();

            //builder.HasMany(c => c.Rounds)
            //    .WithOne(c => c.Course)
            //    .HasForeignKey(c => c.CourseId);



        }
    }
}
