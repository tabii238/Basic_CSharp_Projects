using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new StudentsContext())
            {
                //creating and saving a new student
                Console.Write("Enter student's first and last name: ");
                var studentName = Console.ReadLine();

                Console.Write("Enter student's field of study: ");
                var fieldOfStudy = Console.ReadLine();

                var student = new Student { StudentName = studentName, FieldOfStudy = fieldOfStudy };
                db.Students.Add(student);
                db.SaveChanges();

                //displaying all students from database:
                var query = from x in db.Students
                            orderby x.StudentName
                            select x;

                Console.WriteLine("All students in the database: ");
                foreach (var item in query)
                {
                    Console.WriteLine(item.StudentName + ", " + item.FieldOfStudy);
                    Console.ReadKey();
                }
            }
        }

        public class Student
        {
            public int StudentId { get; set; }
            public string StudentName { get; set; }
            public string FieldOfStudy { get; set; }

            public virtual List<AddStudent> NewStudents { get; set; }
        }

        public class AddStudent
        {
            public int AddStudentId { get; set; }
            public string StudentName { get; set; }
            public string FieldOfStudy { get; set; }

            public int StudentId { get; set; }
            public virtual Student Student { get; set; }
        }

        public class StudentsContext : DbContext
        {
            public DbSet<Student> Students { get; set; }
            public DbSet<AddStudent> NewStudents { get; set; }
        }
    }
}
