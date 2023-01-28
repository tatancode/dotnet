using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Page14
{
    class Program
    {
        public static void Main()
        {
            int r = 10;

            Console.WriteLine(Math.PI);
            Console.WriteLine(2 * Math.PI);
            Console.WriteLine($"A Circle with radius 10 has a circumference of using Math.PI  {2 * Math.PI * r}");
            Console.WriteLine($"A Circle with radius 10 has a circumference of using Math 6.28318  {6.283185307179586 * r}");
            Console.WriteLine($"A Circle with radius 10 has a circumference of using 355/113  {2 * (355 / 113) * r}");

            // modify the statement below to correct the problem: it should not print out 60, but should print out 62.83185...
            double a = 355;
            double b = 113;
            Console.WriteLine($"A Circle with radius 10 has a circumference of using 355/113  {2 * (a / b) * r}");
            // explain why line 19 is wrong here:
            //  The expression in line 19 was incorrect because the values 355 and 113 are integers, which only have a 32 bit size.
            //
            //
        }
    }
}
