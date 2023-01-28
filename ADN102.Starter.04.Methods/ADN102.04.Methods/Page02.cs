using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Page02
{
    class Program
    {

        static public void Main()
        {
            GreetPerson("Emilia");
            GreetPerson("Thomas");
            GreetPerson("Gail");
            GreetPerson("Abraham");
        }
        public static void GreetPerson(string personName)
        {
            Console.WriteLine("Hello " + personName);
        }
    }
    
}
