using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Class_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee Sample = new Employee(); // instantiating the class

            Sample.FirstName = "Sample";
            Sample.LastName = "Student";

            Sample.SayName(); //calling method

            IQuittable newName = new Employee(); // using polymorphism to create an object of type IQuittable()

            newName.Quit(); // calling interface method 
            Console.ReadLine();

        }
    }
}
