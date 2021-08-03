using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTime_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //printing the current date and time to the console
            Console.WriteLine("The current date and time is: " + DateTime.Now);

            Console.WriteLine("Enter a number");
            double input = Convert.ToDouble(Console.ReadLine()); //converting input to data type double for calculation in var futureTime below
            var futureTime = DateTime.Now.AddHours(input); // adding the number the user entered to the hours in the current date to determine a future time
            Console.WriteLine("In " + input + " hours, it will be: " + futureTime); // printing the future time that was calculated based on the user's input
            Console.ReadLine();
        }
    }
}
