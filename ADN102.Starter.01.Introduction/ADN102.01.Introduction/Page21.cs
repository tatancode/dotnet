using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Page21
{
    class Program
    {
        public static object StudentMain(int parameterOne, int parameterTwo)
        {
            // declare a  message variable capable of holding a string of characters here;
            string message;
           
           
            // give it a value here
            // use interpolation and use the two parameters to build a template
            message = $"parameterOne has a value of '{parameterOne}' and parameterTwo has a value of '{parameterTwo}', Adding the two together gives a total value of '{parameterOne + parameterTwo}'!";
            
            // it should say: parameterOne has a value of 'xxx' and parameterTwo has a value of 'yyy', Adding the two together gives a total value of 'zzz'!

            // return the value from Main here
            return message;
            
        }
    }
}
