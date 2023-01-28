using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Page24
{
    class Program
    {
        public static string StudentMain(int number)
        {
            
            


                // make this method return the string EVEN if the parameter number is EVEN
                if (number % 2 == 0)
                {
                    return ("EVEN");

                }
                // and ODD if the parameter number is ODD
                else if (number % 2 == 1)
                {
                    return ("ODD");

                }

            // the modulus operator returns the remainder when dividing x by y 
            // modulus =  x % y





            return "";
        }
    }
}
