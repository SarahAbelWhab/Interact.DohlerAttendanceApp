using System;
using System.Collections.Generic;
using System.Text;

namespace DohlerAttendanceApp.Core.Domain
{
    public class Round
    {
        public Guid Id { get; set; }
        public int Status { get; set; }
        public int TimeSchedule { get; set; }
        public DateTime CompleteDate { get; set; }

        public Guid CourseId { get; set; }
        //public Course Course { get; set; }

        //public virtual ICollection<Survey> Surveys { get; set; }
        //public virtual ICollection<TargetAudience> TargetAudiences { get; set; }
        //public virtual ICollection<TrainingImpact> TrainingImpacts { get; set; }
        //public virtual ICollection<AudienceHistory> AudienceHistories { get; set; }
    }
}
