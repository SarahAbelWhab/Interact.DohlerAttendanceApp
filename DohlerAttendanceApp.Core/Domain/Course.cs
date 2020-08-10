using System;
using System.Collections.Generic;
using System.Text;

namespace DohlerAttendanceApp.Core.Domain
{
    public class Course
    {
        public Guid Id { get; set; }

        public string Title { get; set; }

        public string Name { get; set; }

        public int PlanningType { get; set; }

        public int Type { get; set; }

        public DateTime Duration { get; set; }
        
        public Guid TrainerId { get; set; }
        //public Trainer Trainer { get; set; }

        public Guid CategoryId { get; set; }
        //public Category Category { get; set; }

        //public virtual ICollection<Round> Rounds { get; set; }
    }
}
