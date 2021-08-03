using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shipping_Price_Quote
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below:");
            Console.WriteLine("Enter the weight of your package:"); // prompts user input
            string packageWeight = Console.ReadLine();
            int weight = Convert.ToInt32(packageWeight); // converts input to int data type so it is usable for later operations

            // branching using ternary operator that states that if the weight is greater than 50 it can't be shipped and the program ends...
            // otherwise, the program will prompt the user to input the dimensions of the package
            if (weight > 50)
            {
                Console.WriteLine("Sorry, your package is too heavy to be shipped via Package Express. Have a great day!"); //message to print if weight is greater than 50
            }

            else
            {
                Console.WriteLine("Enter the width of your package:"); // prompts user input 
                string packageWidth = Console.ReadLine();
                int width = Convert.ToInt32(packageWidth); //  converts input to integer

                Console.WriteLine("Enter the height of your package:");
                string packageHeight = Console.ReadLine();
                int height = Convert.ToInt32(packageHeight);

                Console.WriteLine("Enter the length of your package:");
                string packageLength = Console.ReadLine();
                int length = Convert.ToInt32(packageLength);

                int sum = height + width + length; // calculation that adds the dimensions of the package 
                
                int quote = height * width * length * weight / 100; // variable "quote" is the calculation that determines the shipping cost

                if ( sum > 50)
                {
                    Console.WriteLine("Sorry, your package is too big to be shipped via Package Express."); // message to print if height * width * length * weight / 100 is greater than 50
                }
                else
                {
                    Console.WriteLine("Your estimated total for shipping this package is: $" + quote);
                }
            }
            Console.ReadLine(); // keeps the program open until the user closes it

        }
    }
}