using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Six_Part_Assignment
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //PART ONE:
            //create a one - dimensional array of strings
            string[] musicGenres = new string[5] { "Classical", "Blues", "Folk", "Jazz", "Rock" };

            //ask the user to input some text
            Console.WriteLine("Enter your favorite musical instrument:");

            string favInstrument = Console.ReadLine(); // read the line and store in array 

            Console.WriteLine("Press any key to print the appended array:");
            Console.ReadLine();

            // a loop that prints off each string in the array on a separate line
            foreach (string genre in musicGenres)
            {
                Console.WriteLine(genre + " " + favInstrument);
            }

            //PART TWO: 
            //add an infinite loop

            Console.WriteLine("This loop prints the instrument you entered:");
            while (true)
            {
                Console.WriteLine(favInstrument);
                break; //fixes the infinite loop so that it will execute properly by stopping it after printing once
            }

            //PART THREE:
            //add a loop where the comparison that's used to detemine whether to continue iterating through the loop is a "<" operator.
            int[] years = new int[3] { 1980, 1990, 2000 };
            while (true)
            {
                if (years[0] < years[2])
                {
                    Console.WriteLine(years[0]);
                }
                break;
            }

            //add a loop where the comparison that's used to determine whether to continue iterating the loop is a "<="

            int[] speedLimit = new int[5] { 25, 35, 45, 50, 60 };
            for (int i = 0; i < speedLimit.Length; i++)
            {
                if (speedLimit[i] <= 35)
                {
                    Console.WriteLine("Please drive slow");
                }
            }
            Console.ReadLine();

            //PART FOUR: 
            //add a list of strings where each item in the list is unique
            List<string> carModels = new List<string>() { "Altima", "Sentra", "Armada", "Xterra", "Leaf" };

            //ask the user to input text to search for in the list
            Console.WriteLine("Enter a type of car to display its index on the list:");

            string searchString = Console.ReadLine();

            //add a loop that iterates through the list and then displays the index of the list that contains matching text on the screen
            for (int i = 0; i < carModels.Count; i++)
            {
                if (carModels[i] == searchString)
                {
                    Console.WriteLine("Car match found at index " + i);
                    break; //add code to the loop that stops it from executing once a match has been found
                }
            }

            if (!carModels.Contains(searchString)) //add code to the loop to check if the user put in text that isn't on the list and, if they did, tells the user their input is not on the list
            {
                Console.WriteLine("The list doesn't contain the car " + searchString);
            }
            Console.ReadLine();

            //PART FIVE:
            //add a list of strings that has at least two identical strings in the list.
            List<string> treeType = new List<string>() { "Maple", "Spruce", "Pine", "Birch", "Spruce", "Pine" };

            //ask the user to select text to search for in the list
            Console.WriteLine("Enter a type of tree to search for its index(es) in the list:");

            string treeSearch = Console.ReadLine();

            //create a loop that iterates through the list and then displays the indexes of the items matching the user-selected text
            for (int i = 0; i < treeType.Count; i++)
            {
                if (treeType[i] == treeSearch)
                {
                    Console.WriteLine("Match found at index " + i);
                }
            }

            //Add code to the loop to check if the user put in text that isn't on the list and, if they did, tells the user their input is not on the list:
            if (!treeType.Contains(treeSearch))
            {
                Console.WriteLine("The list doesn't contain the item " + treeSearch);
            }
            Console.ReadLine();

            //PART SIX:
            //create a list of strings that has at least two identical strings in the list
            List<string> movieGenres = new List<string>() { "Comedy", "Horror", "Comedy", "Documentary", "Documentary", "Fantasy" };

            //            //create a foreach loop that evaluates each item in the list, and displays a message showing the string and whether or not it has already appeared in the list
            foreach (string movie in movieGenres)
            {

                IEnumerable<string> duplicates = movieGenres.GroupBy(x => x)
                                    .SelectMany(g => g.Skip(1));

                Console.WriteLine("Duplicate elements are: " + String.Join(", ", duplicates));
                break;
            }
            Console.ReadLine();

        }
    }
}

