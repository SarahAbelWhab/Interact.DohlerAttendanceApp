using System;
using System.Collections.Generic;
using System.Text;
using DohlerAttendanceApp.Core.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DohlerAttendanceApp.DAL.Configuration
{
    public class SessionConfig : IEntityTypeConfiguration<Session>
    {
        public void Configure(EntityTypeBuilder<Session> builder)
        {
            builder.HasKey(o => o.Id);

            //builder.HasMany(c => c.AudienceHistories)
            //    .WithOne(c => c.Session)
            //    .HasForeignKey(c => c.SessionId);
        }
    }
}
