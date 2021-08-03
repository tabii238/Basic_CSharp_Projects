using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main_Method_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculation calculation1 = new Calculation(); //instantiating the class "Calculation" that holds the methods called later

            Console.WriteLine("Enter the number of gallons of gas you need to get the total price: "); // prompts user input
            int numberofGallons = Convert.ToInt32(Console.ReadLine()); // integer to pass into method called in next step

            calculation1.GasPriceCalculator(numberofGallons); // calling first method

            Console.WriteLine("It would cost $" + calculation1.GasPriceCalculator(numberofGallons)); // displays result 

            Console.WriteLine("Enter the number of miles in your trip to calculate your average MPG: "); 
            decimal numberofMiles = Convert.ToDecimal(Console.ReadLine()); // decimal to pass into method called in next step 

            calculation1.GasPriceCalculator(numberofMiles); // calling second method

            Console.WriteLine("Your average MPG is: " + calculation1.GasPriceCalculator(numberofMiles)); // displays result after converting to integer within method

            Console.WriteLine("Enter your the total number of miles on your odometer: ");
            string OdometerMiles = Console.ReadLine(); // string to pass into method called in next step

            calculation1.GasPriceCalculator(OdometerMiles); // calling method

            Console.WriteLine("Your total miles before your trip were: " + calculation1.GasPriceCalculator(OdometerMiles)); // displays result converting to integer

            Console.ReadLine(); // keeps program open until closed by user
            


        }
    }
}
