using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathAndComparisonsOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            //int total = 5 + 10;
            //int otherTotal = 12 + 22;
            //int combined = total = otherTotal;
            //Console.WriteLine(combined);
            //Console.WriteLine("Five plus Ten = " + total.ToString());

            //int difference = 10 - 5;
            //Console.WriteLine("Ten minus Five = " + difference.ToString());
            //Console.ReadLine();

            //int product = 10 * 5;
            //Console.WriteLine(product);
            //Console.ReadLine();

            //double quotient = 100.0 / 17.0;
            //Console.WriteLine(quotient);
            //Console.ReadLine();

            //modulus operator: % . Also proves if a number is even or odd
            //int remainder = 11 % 2;
            //Console.WriteLine(remainder); 
            //Console.ReadLine();

            ////Comparison Operators output a BOOLEAN value
            //bool trueOrFalse = 12 > 5;
            //Console.Write(trueOrFalse.ToString());
            //Console.ReadLine();

            //int roomTemperature = 70;
            //int currentTemperature = 68;

            ////bool isWarm = currentTemperature <= roomTemperature;
            //bool isWarm = currentTemperature != roomTemperature;

            //Console.WriteLine(isWarm);
            //Console.ReadLine();

            // ASSIGNMENT:
            // 1. take an input from the user, multiply it by 50, and prints the result

            Console.WriteLine("Enter a number!"); // prompts the user to enter a number
            string num1 = Console.ReadLine(); // assigns a string value to user's input
            int num2 = Convert.ToInt32(num1); // converts input to integer data type
            int product = num2 * 50; // creating a variable called product to store the result of the operation
            Console.WriteLine(product); // prints the result

            Console.ReadLine(); // keeps the program open until the user closes it

            // 2. take an input from the user, add 25 to it, print the result

            Console.WriteLine("Enter a number!");
            string num4 = Console.ReadLine();
            int num5 = Convert.ToInt32(num4);
            int total = num5 + 25;
            Console.WriteLine(total);

            Console.ReadLine();

            // 3. take an input, divide is by 12.5, print the result

            Console.WriteLine("Enter a number!");
            string num7 = Console.ReadLine();
            double num8 = Convert.ToDouble(num7);
            Console.WriteLine(num8 / 12.5);

            Console.ReadLine();

            // 4. take an input, checks if it is greater than 50, then prints the true/false result to the console

            Console.WriteLine("Enter a number!");
            string numA = Console.ReadLine();
            int numC = Convert.ToInt32(numA);
            Console.WriteLine(numC > 50);

            Console.ReadLine();

            // 5. takes an input, divides it by 7, then prints the remainder to the console

            Console.WriteLine("Enter a number!");
            string numD = Console.ReadLine();
            int numE = Convert.ToInt32(numD);
            Console.WriteLine(numE % 7); // modulus operator % will print the remainder after multiplying user's input by 7

            Console.ReadLine();

        }
    }
}
