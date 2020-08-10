using System;
using System.Collections.Generic;
using System.Text;
using DohlerAttendanceApp.Core.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DohlerAttendanceApp.DAL.Configuration
{
    public class TargetAudienceConfig : IEntityTypeConfiguration<TargetAudience>
    {
        public void Configure(EntityTypeBuilder<TargetAudience> builder)
        {
            builder.HasKey(o => o.Id);

           
        }
    }
}
