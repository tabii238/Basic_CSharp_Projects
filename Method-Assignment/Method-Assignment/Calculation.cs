using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Assignment
{
    class Calculation
    {
        // a method that takes two integers as parameters, one of which is optional (item2Price, default is 0)
        public int DiscountCalculator(int item1Price, int item2Price = 0) 
        {
            int discount = 10;
            int priceAfterDiscount = item1Price + item2Price - discount; //calculation performed on variables
            return priceAfterDiscount;
        }
    }
}