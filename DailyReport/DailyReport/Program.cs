using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyReport
{
    class Program
    {
        static void Main(string[] args) // entry point of the program
        {
            Console.WriteLine("The Tech Academy");
            Console.WriteLine("What is your name?");
            string yourName = Console.ReadLine(); // displays user input 

            Console.WriteLine("What course are you on?");
            string yourCourse = Console.ReadLine();

            Console.WriteLine("What page number?");
            string pageNum = Console.ReadLine();
            int page = Convert.ToInt32(pageNum);
            
            Console.WriteLine("Do you need help with anything? Please answer \"True\" or \"False\""); // specifies that the answer to this must be a boolean value
            string input = Console.ReadLine(); 
            bool isBool;
            bool inputBool;

            isBool = Boolean.TryParse(input, out inputBool);

            while (isBool != true) // specifies that if anything other than "true" or "false" is inputted by the user, 
            {
                Console.WriteLine("Please type \"True\" or \"False\""); // this message will appear 
                input = Console.ReadLine();

                isBool = Boolean.TryParse(input, out inputBool);
            } 

            Console.WriteLine("Were there any positive experiences you'd like to share? Please give specifics");
            string yourPositives = Console.ReadLine();

            Console.WriteLine("Is there any other feedback you'd like to provde? Please be specific.");
            string yourFeedback = Console.ReadLine();

            Console.WriteLine("How many hours did you study?");
            string hoursStudied = Console.ReadLine();
            int hours = Convert.ToInt32(hoursStudied);

            Console.WriteLine("Thank you for your answers! An instructor will respond to this shortly. Have a great day!");
            Console.ReadLine(); // keeps the program open until the user closes the it
        }
    }
}
