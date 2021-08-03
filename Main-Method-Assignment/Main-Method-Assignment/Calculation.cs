using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main_Method_Assignment
{
    class Calculation
    {
        //method 1: takes in an integer, performs a math operation, then returns the answer as an integer
        public int GasPriceCalculator(int numberOfGallons)
        {
            int pricePerGallon = 4;
            int GasPrice = numberOfGallons * pricePerGallon;
            return GasPrice;
        }
        
        //method 2: a method with the same name that takes in a deciaml, performs a different math operation, and returns the answer as an integer
        public int GasPriceCalculator (decimal NumberofMiles)
        {
            decimal numberofGallons = 17;
            decimal newPrice = NumberofMiles / numberofGallons;
            int newGasPrice = Convert.ToInt32(newPrice);
            return newGasPrice;
        }


        //method 3: a method with the same name that takes in a string, converts it to an integer, does a different math operation, and returns the answer as an integer
        public int GasPriceCalculator(string OdometerMiles) 
        {
            int tripMiles = 3300;
            int Miles = Convert.ToInt32(OdometerMiles); // converting string to integer
            int OdometerBeforeTrip = Miles - tripMiles;
            return OdometerBeforeTrip;
        }
    }
}
