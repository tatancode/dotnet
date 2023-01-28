using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// Write, compile, and test a program named SumIntegers that allows users to enter as many integers
// as they wish on a single line and displays their sum. You will need to input the single line and
// break it apart into the individual integers in order to process them.
// Display a running total of each acceptable integer, and reject any invalid entries:

//  Enter as many integers as you wish (seperated by a space)
//1 2 3 4
//Processing 0:1
//Accepted 1 total: 1
//Processing 1:2
//Accepted 2 total: 3
//Processing 2:3
//Accepted 3 total: 6
//Processing 3:4
//Accepted 4 total: 10
//The final total of acceptable integers is 10
//Enter as many integers as you wish (seperated by a space)  ^C

// some invalid entries

//Enter as many integers as you wish(seperated by a space)
//1 two 3 four 5 6 7;
//Processing 0:1
//Accepted 1 total: 1
//Processing 1:two
//rejected: two
//Processing 2:3
//Accepted 3 total: 4
//Processing 3:four
//rejected: four
//Processing 4:5
//Accepted 5 total: 9
//Processing 5:6
//Accepted 6 total: 15
//Processing 6:7
//Accepted 7 total: 22
//Processing 7:;
//rejected:;
//The final total of acceptable integers is 22
//Enter as many integers as you wish (seperated by a space) ^C

namespace Page12Problem1
{
    class Program
    {
        public static void Main()
        {
            // enter an infinite loop
            // prompt the user to enter integers
            // read the user input
            // split the user input into individual elements
            // setup a running total to 0
            // loop over the individual elements
            // print out processing message
            // try to parse the element into the correct value
            // success
            // accumulate the value into the sum
            // print out success message
            // failure
            // ignore the value
            // print out failure message
            // after loop is over:  print out accumulated sum
            Console.WriteLine("Enter as many integers as you want separated by spaces, press enter when you are ready for the sum:");
            string numbers = Console.ReadLine();
            var newNumbers = numbers.Split(' ');
            int total = 0;
            foreach (string s in newNumbers)
            {
                int lastNumber;
                if (int.TryParse(s, out lastNumber))
                {
                    total += lastNumber;
                    Console.WriteLine($"Accepted: {lastNumber}, total is now {total}");
                }
                else
                {
                    Console.WriteLine($"Value '{s}' is an invalid integer");
                }

                
            }
            Console.WriteLine($"The total sum is {total}");
        }
    }
}
