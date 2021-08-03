using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Handling_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // creating a list of integers:
            List<int> numbers = new List<int>() { 5, 12, 19, 26 };

            // creating a try/catch block to hold loop
            try
            {
                Console.WriteLine("Pick a number to divide each number in the list by: ");  // ask user for a number to divie each number in the list by

                int numberInput = Convert.ToInt32(Console.ReadLine()); //converts user's input to integer form (since input is automatically stored as a string) so that the calculation can be executed later 

                //creating a loop that takes each integer in the list, divides it by the number the user entered, and displays the results
                foreach (int number in numbers)
                {
                    Console.WriteLine(number / numberInput);
                }
            }

            catch (FormatException ex) // will catch if the format of the user's input is not a number 
            {
                Console.WriteLine("Please type a whole number.");
                return;
            }
            catch (DivideByZeroException ex) // will catch if the user's input to divide the numbers by is 0
            {
                Console.WriteLine("Can't divide by 0.");
            }
            catch (Exception ex) // will catch any other error in the input 
            {
                Console.WriteLine(ex.Message);
            }
            finally // this code will always execute regardless of user input and exceptions
            {
                Console.ReadLine();
            }
            Console.ReadLine();
        }
    }
}
      
