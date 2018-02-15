using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod2_Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a while loop
            // We start with n = 1
            // The condition check for the while, tests if n is less than 6, if so, the loop body code executes
            // inside the loop, we output the value of n and then increment it by 1
            // Once n = 6, the loop stops
            // Pay attention to the output to see what the last value is to ensure you understand
            // how the evaluation of the condition is done and how the while loop executes
            int n = 1;
            while (n < 6)
            {
                Console.WriteLine($"Current value of n is {n}");
                n++;
            }

            // Create a do loop, also known as a do..while loop
            // Note that with the do loop, the loop will run at least once regardless of the value of x
            // which is due to the condition not being checked until the end.
            // Experiment with this by setting x to a value greater than 5 and run the code
            int x = 0;
            do
            {
                Console.WriteLine(x);
                x++;
            } while (x < 5);
        }
    }
}
