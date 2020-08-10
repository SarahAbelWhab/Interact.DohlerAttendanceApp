using System;
using System.Collections.Generic;
using System.Text;

namespace DohlerAttendanceApp.Core.Domain
{
    public class AudienceHistory
    {
        public Guid Id { get; set; }
      
        public DateTime TimeIn { get; set; }

        public DateTime TimeOut { get; set; }

        public Guid RoundId { get; set; }
        //public Round Round { get; set; }

        public Guid SessionId { get; set; }
        //public Session Session { get; set; }

        //public Employee Employee { get; set; }
    }
}
