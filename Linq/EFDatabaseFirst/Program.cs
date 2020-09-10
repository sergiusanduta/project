using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDatabaseFirst
{
    class Instructor
    {
        public int PersonId { get; set; }
        public string LastName { get; set; }
    }

    class Program
    {
        private static string ConnectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

        static void Main(string[] args)
        {
            List<Person> instructors = GetPeople();

            //foreach (Person instructor in instructors)
            //{
            //    Console.WriteLine(instructor.LastName + " " + instructor.FirstName);
            //}


            using (SchoolModel schoolDb = new SchoolModel())
            {
                //Person p = new Person();
                //p.FirstName = "John";
                //p.LastName = "Doe";
                //p.Discriminator = "Student";
                //p.EnrollmentDate = DateTime.Now;

                //schoolDb.People.Add(p);
                //schoolDb.SaveChanges();


                Person liYan = schoolDb.People.FirstOrDefault(_ => _.LastName == "Li" && _.FirstName == "Yan");
                if (liYan != null)
                {
                    liYan.Discriminator = "Instructor";

                    schoolDb.SaveChanges();
                }

                bool johnDoeExists = schoolDb.People.Any(_ => _.LastName == "Doe" && _.FirstName == "John");
                if (johnDoeExists)
                {
                    Person johnDoe = schoolDb.People.First(_ => _.LastName == "Doe" && _.FirstName == "John");
                    schoolDb.People.Remove(johnDoe);

                    schoolDb.SaveChanges();
                }
            }


            int totalStudents = GetTotalStudents();
            Console.WriteLine(totalStudents);


            Console.ReadKey();
        }

        // Entity Framework
        private static List<Person> GetPeople()
        {
            using (SchoolModel schoolDb = new SchoolModel())
            {
                List<Person> people = schoolDb.People.ToList();
                return people;
            }
        }

        private static List<Person> GetAllInstructors()
        {
            using (SchoolModel schoolDb = new SchoolModel())
            {
                List<Person> people = schoolDb.People.Where(person => person.Discriminator == "Instructor").ToList();
                return people;
            }
        }

        private static List<Person> GetAllStudents()
        {
            using (SchoolModel schoolDb = new SchoolModel())
            {
                List<Person> people = schoolDb.People.Where(person => person.Discriminator == "Student").ToList();
                return people;
            }
        }

        private static List<Course> GetAllCourses()
        {
            using (SchoolModel schoolDb = new SchoolModel())
            {
                List<Course> courses = schoolDb.Courses.ToList();
                return courses;
            }
        }

        private static Person GetLopezSophia()
        {
            using (SchoolModel schoolDb = new SchoolModel())
            {
                Person person = schoolDb.People.FirstOrDefault(p => p.LastName == "Lopez" && p.FirstName == "Sophia");
                return person;
            }
        }

        private static int GetTotalStudents()
        {
            using (SchoolModel schoolDb = new SchoolModel())
            {
                int total = schoolDb.People.Count(p => p.Discriminator == "Student");
                return total;
            }
        }




        // ADO.NET
        //    private static List<Instructor> GetAllInstructors()
        //    {
        //        List<Instructor> instructors = new List<Instructor>();

        //        using (SqlConnection connection = new SqlConnection(ConnectionString))
        //        {
        //            using (SqlCommand command = new SqlCommand("SELECT * FROM Person", connection))
        //            {
        //                connection.Open();
        //                command.CommandType = System.Data.CommandType.Text;
        //                using (var reader = command.ExecuteReader())
        //                {
        //                    while (reader.Read())
        //                    {
        //                        Instructor instructor = new Instructor();
        //                        instructor.LastName = reader["LastName"].ToString();
        //                        instructor.PersonId = Convert.ToInt32(reader["PersonID"]);
        //                        instructors.Add(instructor);
        //                    }
        //                }

        //            }
        //        }
        //        return instructors;
        //    }
    }
}
