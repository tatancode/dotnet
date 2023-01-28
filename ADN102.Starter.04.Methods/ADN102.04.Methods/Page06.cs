using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Page06
{
    class Program
    {

        public static void Main()
        {
            int n = 1;
            int other = 1000;
            Console.WriteLine($"inside Main before: n= {n}, other = {other}");
            other = Add10(ref n);  // note the ref 
            Console.WriteLine($"inside Main after: n= {n}, other = {other}");
        }

        public static int Add10(ref int n)  // note the ref
        {
            Console.WriteLine($"inside Add10 before: n= {n}");
            n = n + 10;
            // n += 10;
            Console.WriteLine($"inside Add10 after: n= {n}");
            return n;
        }
    }
}
