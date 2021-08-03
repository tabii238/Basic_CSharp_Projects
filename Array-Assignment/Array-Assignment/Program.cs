using System;
using System.Collections.Generic;



    class Program
    {
        static void Main(string[] args)
        {
        // array of strings:
        string[] stringArray = { "Today is Tuesday, July 13th!", "It's 63 degrees outside", "It's mostly sunny with a 10% change of rain." };

        // array of integers: 
        int[] intArray = { 13, 14, 15, 16 };

        // list:
        List<string> myList = new List<string>();

        myList.Add("Tomorrow the high will be 77 degrees");
        myList.Add("The high for the week is 84 degrees");
        myList.Add("The high on the coast is only 60 degrees");
       
        bool keepLooping = true;
        while (keepLooping == true)
        {
            Console.WriteLine("Enter a number to display the string at that index!"); // prompts user input
            try
            {
                int index = int.Parse(Console.ReadLine());
                Console.WriteLine(stringArray[index].ToString()); // will display the value at the index corresponding to the user's input 
                keepLooping = false; // loop will end after this iteration
            }
            catch // displays message if user selects a number that doesn't correspond to an index
            {
                Console.WriteLine("Sorry, there is no string at that index.");
            }

            {
                Console.WriteLine("Enter a number to display the integer at that index!"); // prompts user input
                try
                {
                    int index = int.Parse(Console.ReadLine());
                    Console.WriteLine(intArray[index].ToString()); // will display the value at the index corresponding to the user's input 
                    keepLooping = false; // loop will end after this iteration
                }
                catch // displays message if user selects a number that doesn't correspond to an index
                {
                    Console.WriteLine("Sorry, there is no integer at that index.");
                }

                Console.WriteLine("Enter a number to display a portion of my list!"); // prompts user input
                try
                {
                    int index = int.Parse(Console.ReadLine());
                    Console.WriteLine(myList[index].ToString());
                    keepLooping = false; // loop will end after this iteration
                }
                catch // displays message if user selects a number that doesn't correspond to an index
                {
                    Console.WriteLine("Sorry, there is no value at that index.");
                }
                Console.ReadLine();
            }
        }
      
    }
}

