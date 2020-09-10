namespace EFDatabaseFirst
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class SchoolModel : DbContext
    {
        public SchoolModel()
            : base("name=SchoolModelConnectionString")
        {
        }

        public virtual DbSet<Course> Courses { get; set; }
        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<OfficeAssignment> OfficeAssignments { get; set; }
        public virtual DbSet<OnlineCourse> OnlineCourses { get; set; }
        public virtual DbSet<OnsiteCourse> OnsiteCourses { get; set; }
        public virtual DbSet<Person> People { get; set; }
        public virtual DbSet<StudentGrade> StudentGrades { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Course>()
                .HasOptional(e => e.OnlineCourse)
                .WithRequired(e => e.Course);

            modelBuilder.Entity<Course>()
                .HasOptional(e => e.OnsiteCourse)
                .WithRequired(e => e.Course);

            modelBuilder.Entity<Course>()
                .HasMany(e => e.StudentGrades)
                .WithRequired(e => e.Course)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Course>()
                .HasMany(e => e.People)
                .WithMany(e => e.Courses)
                .Map(m => m.ToTable("CourseInstructor").MapLeftKey("CourseID").MapRightKey("PersonID"));

            modelBuilder.Entity<Department>()
                .Property(e => e.Budget)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Department>()
                .HasMany(e => e.Courses)
                .WithRequired(e => e.Department)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OfficeAssignment>()
                .Property(e => e.Timestamp)
                .IsFixedLength();

            modelBuilder.Entity<Person>()
                .HasOptional(e => e.OfficeAssignment)
                .WithRequired(e => e.Person);

            modelBuilder.Entity<Person>()
                .HasMany(e => e.StudentGrades)
                .WithRequired(e => e.Person)
                .HasForeignKey(e => e.StudentID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<StudentGrade>()
                .Property(e => e.Grade)
                .HasPrecision(3, 2);
        }
    }
}
