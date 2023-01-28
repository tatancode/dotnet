using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Page04
{
    class Program
    {
        // run this program at least two times:

        // type in 1 , 5 for the starting and ending the first time
        // type in 5 , 1 for the starting and ending the second time
        // also try typing in hello or goodbye instead of one of the numbers to see what happens
        public static void Main()
        {
            int starting;
            int ending;
            string line1;
            string invalid = "";

            do
            {
                // the first time through, invalid is "" and will not print anything out
                Console.Write($"{invalid}Type a starting integer:");
                line1 = Console.ReadLine();
                invalid = "Invalid format for an integer,";

            } while (!int.TryParse(line1, out starting));
            Console.WriteLine($"You typed a valid value of {starting} for the starting integer");
            invalid = "";

            do
            {
                // the first time through, invalid is "" and will not print anything out
                Console.Write($"{invalid}Type an ending integer:");
                line1 = Console.ReadLine();
                invalid = "Invalid format for an integer,";

            } while (!int.TryParse(line1, out ending));
            Console.WriteLine($"You typed a valid value of {ending} for the  ending integer");
            Console.WriteLine("*****FOR******");
            for (int j = starting; j<ending; j++)
            {
                Console.WriteLine($"Going from {starting} to {ending} at {j} in for loop");
            }
            Console.WriteLine("*****DO******");
            do
            {
                Console.WriteLine($"Going from {starting} to {ending} in do loop");
                starting++;
            } while (starting < ending);


        }
    }
}
