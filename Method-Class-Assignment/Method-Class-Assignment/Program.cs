using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Class_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Example MethodClass = new Example(); // instantiating  the class:

            Console.WriteLine("Enter a number: ");   //prompting user input/passing two numbers to the method:
            int userValue = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Enter a second number: ");
            int userValue2 = Convert.ToInt32(Console.ReadLine());

            MethodClass.MathOp(userValue, userValue2); //calling the void method

            Console.ReadLine();

        }
    }
}
