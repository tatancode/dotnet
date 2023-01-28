using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Page10
{
    class Program
    {
        public static void Main()
        {
            // this section of code is outside of any try block
            int i = 10;
            int j = 0;
            try
            {
                
                subroutine(10);
                subroutine(0);
                subroutine(-10);
                Console.WriteLine("Do you see this line in the output???");

            }
            catch (Exception ex)
            {
                Console.WriteLine($"an exception was triggered {ex}");
                // code to log the exception to a database or a file could be located here.
            }
            finally  // the finally is optional (unless you dont have any catches)
            {
                // this code always executes
                Console.WriteLine("main Finally is executing...");
            }
        }

        static int subroutine(int x)
        {
            try
            {
                if (x < 0)
                {
                    throw new Exception($"the parameter to subroutine ({x}) was less than zero");
                    // this line will never be executed
                }
                return 10 / x;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Tried to divide by zero....Not Allowed.");
                Console.WriteLine("Returning 0 instead of infinity");
                return 0;
            }
            finally  // the finally is optional (unless you dont have any catches).  
                     // you do not have to have it
            {
                Console.WriteLine("subroutine Finally is executing...");
                // this code always executes
            }
        }
    }
}
