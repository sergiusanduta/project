
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCodeFirstDemo.Models
{
    class A : DbContext
    {
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Course> Courses { get; set; }
        public virtual DbSet<Enrollment> Enrollments { get; set; }
    }
}
