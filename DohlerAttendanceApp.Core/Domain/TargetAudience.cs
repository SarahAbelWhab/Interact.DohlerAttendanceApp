using System;
using System.Collections.Generic;
using System.Text;

namespace DohlerAttendanceApp.Core.Domain
{
    public class TargetAudience
    {
        public Guid Id { get; set; }

        public Guid EmployeeId { get; set; }
        //public Employee Employee { get; set; }

        public Guid RoundId { get; set; }
        //public Round Round { get; set; }
    }
}
