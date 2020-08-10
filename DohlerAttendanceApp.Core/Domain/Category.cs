using System;
using System.Collections.Generic;
using System.Text;

namespace DohlerAttendanceApp.Core.Domain
{
    public class Category
    {
        public Guid Id { get; set; }

        public string Title { get; set; }

        //public virtual ICollection<Course> Courses { get; set; }
    }
}
