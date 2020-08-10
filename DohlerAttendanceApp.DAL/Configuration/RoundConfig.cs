using System;
using System.Collections.Generic;
using System.Text;
using DohlerAttendanceApp.Core.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DohlerAttendanceApp.DAL.Configuration
{
    public class RoundConfig : IEntityTypeConfiguration<Round>
    {
        public void Configure(EntityTypeBuilder<Round> builder)
        {
            builder.HasKey(o => o.Id);

            builder.Property(t => t.Status)
                .IsRequired();

            builder.Property(t => t.CompleteDate)
                .IsRequired();

            builder.Property(t => t.TimeSchedule)
                .IsRequired();

            //builder.HasMany(c => c.TargetAudiences)
            //    .WithOne(c => c.Round)
            //    .HasForeignKey(c => c.RoundId);

        }
    }

}
