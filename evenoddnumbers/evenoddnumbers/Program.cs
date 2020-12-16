using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace evenoddnumbers
{
    class Program
    {
        static void Main(string[] args)
        { // Declare the variables
            int a, b, i, j, flag;

            // Ask user to enter lower value of interval
            Console.WriteLine("Enter lower bound of " +
                              "the interval: ");

            // Take input
            a = int.Parse(Console.ReadLine());

            // Ask user to enter upper value of interval
            Console.WriteLine("\nEnter upper bound " +
                              "of the interval: ");

            // Take input
            b = int.Parse(Console.ReadLine());

            // Print display message
            Console.WriteLine("\nPrime numbers between " +
                              "{0} and {1} are: ", a, b);

            // Traverse each number in the interval
            // with the help of for loop
            for (i = a; i <= b; i++)
            {

                if (i == 1 || i == 0)
                    continue;

                // flag variable to tell
                // if i is prime or not
                flag = 1;

                for (j = 2; j <= i / 2; ++j)
                {
                    if (i % j == 0)
                    {
                        flag = 0;
                        break;
                    }
                }
                if (flag == 1)
                    Console.WriteLine(i);
		    Console.WriteLine("reventh rao");

            }
        }
    }
}
