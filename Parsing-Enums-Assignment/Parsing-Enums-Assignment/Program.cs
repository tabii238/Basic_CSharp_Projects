using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parsing_Enums_Assignment
{
    class Program
    {
        // creating an enum for the days of the week
        public enum DaysofTheWeek
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
        static void Main(string[] args)
        {
            // try/catch block to catch input errors
            try
            {
                Console.WriteLine("Enter the current day of the week:"); //2. Prompt user to enter the current day of the week

                string dayInput = Console.ReadLine(); //3. Assign the value to a variable of that enum data type you just created
            
                DaysofTheWeek day;

                if (Enum.TryParse<DaysofTheWeek>(dayInput, out day))
                {
                    Console.WriteLine("Today is " + dayInput);
                }
                else
                {
                    throw new OverflowException();
                }
            }
            catch (OverflowException)
            {
                Console.WriteLine("Please enter an actual day of the week");
            }
            Console.ReadLine();
            return;
        }
    }
}




