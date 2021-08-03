using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Insurance_Approval_Program
{
    class Program
    {
        static void Main(string[] args) // start of program
        {
            Console.WriteLine("Car Insurance Approval Program"); // name of program prints first

            Console.WriteLine("What is your age?");
            string userAge = Console.ReadLine();
            int Age = Convert.ToInt32(userAge);  // converting age to int so that it can be used in a boolean expression later

            Console.WriteLine("Have you ever had a DUI? Enter \"True\" or \"False\""); 
            string DUIinput = Console.ReadLine();
            bool isBool;
            bool DUIinputBool;

            isBool = Boolean.TryParse(DUIinput, out DUIinputBool); // converting DUI input to boolean value

            while (isBool != true) // specifies that if anything other than "true" or "false" is inputted by the user, 
            {
                Console.WriteLine("Please type \"True\" or \"False\""); // this message will appear 
                DUIinput = Console.ReadLine();

                isBool = Boolean.TryParse(DUIinput, out DUIinputBool);
            }

            Console.WriteLine("How many speeding tickets do you have?");
            string speedingTickets = Console.ReadLine();
            int Tickets = Convert.ToInt32(speedingTickets); // converting speedingTickets to Int value

            Console.WriteLine("Qualified?");
            bool Qualified = (Age > 15 && DUIinputBool == false && Tickets < 3); // Qualifications: must be over 15, no DUIs, no more than 3 tickets
            Console.WriteLine(Qualified);

            Console.ReadLine();

        }
    }
}
