using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //concatenates three strings
            string name = "Gwen";
            string age = "8 weeks";
            string animal = "kitten";

            Console.WriteLine("Our " + animal + ", " + name + ", " + "is " + age + " old "); 

            //converts a string to uppercase

            name = name.ToUpper();

            Console.WriteLine(name); // will print the name in all uppercase

            //creates a StringBuilder and builds a paragraph of text, one sentence at a time

            StringBuilder sb = new StringBuilder();
            sb.Append("Every year, the neighbors had a garage sale to get rid of their extra stuff.");
            sb.Append(" On Saturday, they were busy!");
            sb.Append(" They sold about half of their items and made over $100.");
            sb.Append(" The next day only a few people stopped by and they only made $30.");
            Console.WriteLine(sb); // will print each sentence listed above to form a paragraph
         
            Console.ReadLine();
        }
    }
}
