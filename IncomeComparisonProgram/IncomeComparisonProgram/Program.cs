using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncomeComparisonProgram
{
    class Program
    {
        static void Main(string[] args) // start of program
        {
            Console.WriteLine("Anonymous Income Comparison Program"); // name of program printed first

            Console.WriteLine("Person 1");

            Console.WriteLine("Hourly Rate?"); // promps user for input
            string hourlyRate1 = Console.ReadLine();
            int Rate1 = Convert.ToInt32(hourlyRate1); // converts string input to integer so that the amount can be multiplied later

            Console.WriteLine("Hours worked per week?");
            string hoursWorked1 = Console.ReadLine();
            int hours1 = Convert.ToInt32(hoursWorked1);

            Console.WriteLine("Person 2");

            Console.WriteLine("Hourly Rate?");
            string hourlyRate2 = Console.ReadLine();
            int Rate2 = Convert.ToInt32(hourlyRate2);

            Console.WriteLine("Hours worked per week?");
            string hoursWorked2 = Console.ReadLine();
            int hours2 = Convert.ToInt32(hoursWorked2);

            Console.WriteLine("Annual salary of Person 1:");
            int Salary1 = (Rate1 * hours1 * 52); // multiplying hours worked and hourly rate by number of weeks in the year
            Console.WriteLine(Salary1);

            Console.WriteLine("Annual salary of Person 2:");
            int Salary2 = (Rate2 * hours2 * 52);
            Console.WriteLine(Salary2);

            Console.WriteLine("Does Person 1 make more money than Person 2?");
            Console.WriteLine(Salary1 > Salary2); // comparison statement that will return "True" or "False" value

            Console.ReadLine(); // keeps the program open until the user closes it 

        }
    }
}
