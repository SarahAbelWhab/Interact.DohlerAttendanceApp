using System;
using System.Collections.Generic;
using System.Text;

namespace DohlerAttendanceApp.Core.Domain
{
    public class Department
    {
        public Guid Id { get; set; }

        public string Name { get; set; }


        public Guid SectorId { get; set; }
        //public Sector Sector { get; set; }

        public Guid ManagerId { get; set; }
        //public Employee Manager { get; set; }

        //public virtual ICollection<Employee> Employees { get; set; }
    }
}
