using System;
using System.Collections.Generic;
using System.Text;
using DohlerAttendanceApp.Core.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DohlerAttendanceApp.DAL.Configuration
{
    public class AudienceHistoryConfig : IEntityTypeConfiguration<AudienceHistory>
    {
        public void Configure(EntityTypeBuilder<AudienceHistory> builder)
        {
            builder.HasKey(o => o.Id);

            builder.Property(c => c.TimeIn).IsRequired();
            builder.Property(c => c.TimeOut).IsRequired();



        }
    }
}
