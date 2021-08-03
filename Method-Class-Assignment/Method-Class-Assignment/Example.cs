using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Class_Assignment
{
    class Example // creating a class
    {
        // creating a void method that takes two integers as parameters, performs a math operation on the first integer and displays the second integer to the screen
        public void MathOp(int userValue, int userValue2)
        {
            int result = userValue * 10 / 2;
            int display = userValue2;

            Console.WriteLine(userValue + " * 10 / 2 = " + result);

            Console.WriteLine("The second number you entered = " + display);
        }
    }
}
