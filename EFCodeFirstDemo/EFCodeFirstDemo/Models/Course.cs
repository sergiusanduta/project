using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCodeFirstDemo.Models
{
    class Course
    {
        public int CourseId { get; set; }
        public string Title { get; set; }
        public int Credit { get; set; }
        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}
