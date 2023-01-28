using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Page4
{
    class Program
    {
        public static void Main()
        {
            int a = 5;
            int b = 5;
            Console.WriteLine($" a:{a} b: {b} a == b: {a == b}");

            a = 5;
            b = 6;
            Console.WriteLine($" a:{a} b: {b} a == b: {a == b}");

            bool result =  a == b;  // == has precedence over = 
            Console.WriteLine($" a:{a} b: {b} result = a == b: {result}");

             result = a != b;      // != has precedence over = 

            Console.WriteLine($" a:{a} b: {b} result = a != b: {result}");



        }
    }
}
