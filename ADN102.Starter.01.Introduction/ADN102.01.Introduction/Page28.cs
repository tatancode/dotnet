using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//You have just hired a new employee named: Lucinda Potter, who was born on the 24th of June in 1992.
//         Their work phone is: 312 - 982 - 1010 and their email is ewoz@woz-u.com.

//Write, compile, and test a program named EmployeeInfo that displays Lucinda's full name,
// birthdate, extension, and email address on the console device.

namespace Page28
{
    class Program
    {
        public static void Main(string [] args)
        {
            //Lucinda Potter
            string fullName = "Lucinda Potter";
            //6/24/1992
            string birthDate = "6/24/1992/";
            //work 312-982-1010
            string extension = "312 - 982 - 1010";
            //email ewoz@woz-u.com
            string email = "ewoz@woz-u.com";

            Console.WriteLine(fullName);
            Console.WriteLine(birthDate);
            Console.WriteLine(extension);
            Console.WriteLine(email);

        }
    }
}
