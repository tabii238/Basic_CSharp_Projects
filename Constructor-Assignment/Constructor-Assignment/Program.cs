using System;

namespace Constructor_Assignment
{ 
    class Program
    {
        static void Main(string[] args)
        {
            const string myProgram = "Sales Commission Calculator"; //creating a const variable

            Console.WriteLine("Enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Welcome to the {0}, {1}!", myProgram, name);
            
            Console.WriteLine("Enter your total sales: ");
            int sales = Convert.ToInt32(Console.ReadLine());

            if (sales <= 500)
            {
                var commission = sales * 0.05; //creating variable using the keyword var
                Console.WriteLine("You would make 5% commission: " + "$" + commission);
            }
            else
            {
                var commission = sales * 0.1;
                Console.WriteLine("You would make 10% commission: " + "$" + commission);
            }
            Console.ReadLine();
        }
    }
}
