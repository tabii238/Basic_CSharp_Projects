using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Class_Assignment
{
    public class Employee : Person, IQuittable
    {
        public string FirstName { get; set; } //two properties: first and last name
        public string LastName { get; set; }

        public override void SayName() // implementing method inheritaed from class Person
        {
            Console.WriteLine("Name: " + FirstName + " " + LastName);
        }

        public void Quit() // implementing method inherited from interface IQuittable 
        {
            Console.WriteLine("Press any key to exit and create a new student: ");
            Console.ReadLine(); // keeps program running until user presses a key
            Console.WriteLine("Enter Student's First and Last Name: "); // prompts next section of program where a new student can be added 
            string newName = Console.ReadLine();
            Console.WriteLine("You entered... \nName: " + newName); // prints the name entered 
            Console.ReadLine();
        }
    }
}
