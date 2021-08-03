using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While_Do_While_Statements
{
    class program
    {
        static void Main(string[] args)
        {
            int i = 1, sum = 0; // sum is initialized to 0 

            // while loop: condition is checked before the body is executed

            while (i <= 5) // when the value of i reaches 6, the loop will terminate 
            {
                sum += i; // with each iteration, the values of sum and i are both incremented by 1
                i++;
            }
            Console.WriteLine("Sum = {0}", sum);

            int j = 1, k = 5, product;

            // do while loop: the condition is checked after the body is executed, so the loop will always execute at least once
            do
            {
                product = k * j;
                Console.WriteLine("{0} * {1} = {2}", k, j, product);
                j++; 
            } while (j <= 10); // loop will keep going until j reaches 10 / k will be multiplied by each number from 1-10

            Console.ReadLine();
        }
    }
}
