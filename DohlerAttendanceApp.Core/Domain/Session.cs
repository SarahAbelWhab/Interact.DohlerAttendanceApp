using System;
using System.Collections.Generic;
using System.Text;

namespace DohlerAttendanceApp.Core.Domain
{
    public class Session
    {
        public Guid Id { get; set; }
        public int SessionNumber { get; set; }
        public int Status { get; set; }
        public DateTime StartDateTime { get; set; }
        public DateTime EndDateTime { get; set; }

        public Guid RoundId { get; set; }
        //public Round Round { get; set; }
        //public virtual ICollection<AudienceHistory> AudienceHistories { get; set; }

    }
}
