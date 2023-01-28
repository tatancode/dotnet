using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Page03
{
    class Program
    {

        public static void Main()
        {
            Console.WriteLine("Counting...");
            for(int i = 0; i< 10; i++)
            {
                Console.WriteLine($"i is {i}, is i < 10 {i < 10}");
            }

            Console.WriteLine("Out of the loop, no longer have access to variable i.");

           

        }
    }
}
