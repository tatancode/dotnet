using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Page04
{
    class Program
    {
        public static void Main1()
        {
            Console.WriteLine(IsEven(2));
        }

        public static bool IsEven(int number)
        {

            bool result;

            // if the number is even, set variable to true
            if (number % 2 == 0)
            {
                result = true;
            }
            // otherwise, set variable to false
            else
            {
                result = false;
            }

            // return the variable
            return result;
        }






        public static void Main2()
        {
            int num1 = 1;
            int num2 = 2;

            // store the returned value of the "add" method
            int sum = 2 * Add(3 + num1, 10 + num2);
            Console.WriteLine(sum);
        }

        // add method returns an integer
        public static int Add(int number1, int number2)
        {
            return (number1 + number2);
        }


    }
}
