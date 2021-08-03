using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Example divTwo = new Example(); //instantiatig the "Example" class:

            Console.WriteLine("Enter a number: "); //prompting user to input a number
            int uservalue = Convert.ToInt32(Console.ReadLine()); // converting input to integer

            divTwo.DivideByTwo(uservalue); //call the method on the user's number


            int argnumber;
            string argmessage, argdefault;
            divTwo.MultiplyByTwo(out argmessage, out argnumber, out argdefault); // calling new method with out parameters

            Console.WriteLine(argmessage);
            Console.WriteLine(argnumber);
            Console.WriteLine(argdefault == null); // printing output

            
            Console.WriteLine("Pick a number: "); // user input
            int userValue2 = Convert.ToInt32(Console.ReadLine()); // converting input to integer

            divTwo.MultiplyByTwo(userValue2, out string message, out int result); // calling the overloaded method
            Console.WriteLine(message + result); 

            Console.WriteLine("Enter the price of an item to calculate the sale price: "); // user input
            double salePrice = Convert.ToDouble(Console.ReadLine()); // converting to double for method 

            Example2.DiscountCalculator(salePrice); // calling new method in static class (no instantiation)

            Console.ReadLine(); // keeps the program open until the user closes it 

        }
    }
}
