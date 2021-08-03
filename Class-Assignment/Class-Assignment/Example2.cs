using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Assignment
{
    static class Example2 // declaring a static class 
    {
        public static void DiscountCalculator (double salePrice) 
        {
            double totalPrice = salePrice - salePrice * 0.3;
            Console.WriteLine("Price after 30% discount would be " + totalPrice);
        }
    }
}
