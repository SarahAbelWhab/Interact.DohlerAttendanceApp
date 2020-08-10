using System;
using System.Collections.Generic;
using System.Text;
using DohlerAttendanceApp.Core.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DohlerAttendanceApp.DAL.Configuration
{
    public class TrainingImpactConfig : IEntityTypeConfiguration<TrainingImpact>
    {
        public void Configure(EntityTypeBuilder<TrainingImpact> builder)
        {
            builder.HasKey(o => o.Id);

        }
    }
}
