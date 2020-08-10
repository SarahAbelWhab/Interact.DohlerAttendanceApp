using System;
using System.Collections.Generic;
using System.Text;

namespace DohlerAttendanceApp.Core.Domain
{
    public class Employee
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Guid DepartmentId { get; set; }
        //public Department Department { get; set; }
    }
}
