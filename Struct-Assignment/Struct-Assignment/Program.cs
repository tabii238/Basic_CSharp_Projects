using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Number num1 = new Number //creating an object of data type number and assigning an amount to it.
            {
                Amount = -67
            };
            Console.WriteLine(num1.Amount);//printing the amount to the console

            Console.ReadLine();
        }
    }
}
