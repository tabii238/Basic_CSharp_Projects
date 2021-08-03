using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculation calculation1 = new Calculation(); // instantiation of class Calculation

            Console.WriteLine("Enter a number: ");
            int userValue = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter another number (optional): ");

            int userValue2;
            int result; 

            // a loop that instructs the compiler to use the default value in the method if the second number is left blank:
            if (int.TryParse(Console.ReadLine(), out userValue2)) 
            {
                result = calculation1.DiscountCalculator(userValue, userValue2); //method is called and assigned to the variable "result"

            }
            else
            {
                result = calculation1.DiscountCalculator(userValue); 
            }

            Console.WriteLine("The total is: " + result);
            Console.ReadLine();
        }
    }
}
