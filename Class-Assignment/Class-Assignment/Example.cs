using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Assignment
{
    class Example
    {
        public void DivideByTwo(int userValue) // creating a void method that outputs an integer
        {
            int output = userValue / 2; // divides the data passed to it by 2
            Console.WriteLine("Your number divided by 2 = " + output);
        }


        public void MultiplyByTwo(out string message, out int product, out string stillNull) //creating a method with output parameters
        {
            product = 15 * 7;
            message = "The product of 15 and 7 is: ";
            stillNull = null;
        }

        public void MultiplyByTwo(int userValue2, out string message, out int result) //overloading a method
        {
            result = userValue2 * 2;
            message = "Your number times 2 is ";
        }
    }
}