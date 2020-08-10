using System;
using System.Collections.Generic;
using System.Text;

namespace DohlerAttendanceApp.Core.Domain
{
    public class Sector
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        //public virtual ICollection<Department> Departments { get; set; }
    }
}
