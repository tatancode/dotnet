using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Page10
{
    class Program
    {
        // "simple" algorithm (iterative approach using a for loop)
        static int SimpleSumIntegerUpToLimit(int limit)
        {
            int sum = 0;
            for (int count = 1; count <= limit; count++)
            {
                sum += count;
            }
            return sum;
        }

        // "clever" algorithm using Gauss' formula
        static int CleverSumIntegerUpToLimit(int limit)
        {
            return (limit * (limit + 1)) >> 1;
        }

        public static void Main()
        {
            int limit;
            int result;
            Stopwatch stopWatch = new Stopwatch();

            // test speed of the "simple" algorithm to 10
            limit = 10;
            stopWatch.Start();
            result = SimpleSumIntegerUpToLimit(limit);
            stopWatch.Stop();
            Console.WriteLine("\nSimple algorithm to" + limit + " is: " + result);
            Console.WriteLine("Ticks: " + stopWatch.ElapsedTicks);
            Console.WriteLine("This is so high because of JIT compiling the first time it is called");
            stopWatch.Reset();

            // test speed of the "clever" algorithm to 10
            stopWatch.Start();
            result = CleverSumIntegerUpToLimit(limit);
            stopWatch.Stop();
            Console.WriteLine("\nClever algorithm to" + limit + " is: " + result);
            Console.WriteLine("Ticks: " + stopWatch.ElapsedTicks);
            Console.WriteLine("This is so high because of JIT compiling the first time it is called");
            stopWatch.Reset();

            // repeat "simple" algorithm test
            limit = 10;
            stopWatch.Start();
            result = SimpleSumIntegerUpToLimit(limit);
            stopWatch.Stop();
            Console.WriteLine("\nSimple algorithm to" + limit + " is: " + result);
            Console.WriteLine("Ticks: " + stopWatch.ElapsedTicks);
            Console.WriteLine("This is a more realistic measure, since the method as already been JIT compiled");
            stopWatch.Reset();

            // repeat "clever" algorithm test
            stopWatch.Start();
            result = CleverSumIntegerUpToLimit(limit);
            stopWatch.Stop();
            Console.WriteLine("\nClever algorithm to" + limit + " is: " + result);
            Console.WriteLine("Ticks: " + stopWatch.ElapsedTicks);
            Console.WriteLine("This is a more realistic measure, since the method as already been JIT compiled");
            stopWatch.Reset();

            // test speed of the "simple" algorithm to 10000
            limit = 10000;
            stopWatch.Start();
            result = SimpleSumIntegerUpToLimit(limit);
            stopWatch.Stop();
            Console.WriteLine("\nSimple algorithm to" + limit + " is: " + result);
            Console.WriteLine("Ticks: " + stopWatch.ElapsedTicks);
            stopWatch.Reset();

            // test speed of the "clever" algorithm to 10000
            stopWatch.Start();
            result = CleverSumIntegerUpToLimit(limit);
            stopWatch.Stop();
            Console.WriteLine("\nClever algorithm to" + limit + " is: " + result);
            Console.WriteLine("Ticks: " + stopWatch.ElapsedTicks);
            stopWatch.Reset();
        }
    }
}
