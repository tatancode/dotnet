using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Page07
{
    class Program
    {

        public static void Main()
        {
            int n;
            int other = 100;
           // Console.WriteLine($"inside Main before: n= {n}, other = {other}");  // error n is unassigned
            other = Add10(out n, true);  // note out is allowed, and anotehr parameter is provided (a bool = true)
            Console.WriteLine($"inside Main after: n= {n}, other = {other}");
        }

        public static int Add10(out int n, bool High)  // note out, and additional parameter
        {
            //Console.WriteLine($"inside Add10 before: n= {n}");  // error n is unassigned
            if (High)
            {
                n = 1000;  // return 1000 to variable n  (n is HIGH) (goes into n on line 14)
            }
            else
            {
                n = 10;    // return 10 to variable n     (n is not HIGH) (goes into n on line 14)
            }
            return 5;  // return 5 as the actual return value (goes into other on line 17)
        }
    }
}
