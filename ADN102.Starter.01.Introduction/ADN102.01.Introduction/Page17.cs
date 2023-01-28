using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Page17
{
    class Program
    {
        static public void Main(string [] args)
        {
            int a;
            int b = 10;
            int c = 5, d = b * 2, e = b * c * d;

            float f;
            float aLongerVariableName = 20;
           // float anEvenLongerVariableName = 20.5;   // 20.5f

            double dd;
            double aLongerDouble = 20;
            double anEvenLongerDouble = 20.5;

            char cc;
            char aLongerChar = 'a';
         //   char anEvenLongerChar = 91;   //  (char) 91

            string s;
            string aLongerStringName = "Hello World!";
            string hasSpecialCharacters = "\t\n\b";
            string verbatim = @"\t\n\b";
            string interpolated = $"text b = {b} a float: {aLongerVariableName} a char in single quotes '{aLongerChar}'";

            bool bb;
            bool isTrue = true;
            bool isFalse = false;
            bool is10GreaterThan20 = 10 > 20;




        }
    }
}
