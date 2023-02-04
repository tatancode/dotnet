using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Page17
{
   
}
namespace ADN102._06.Inheritance
{

    class Tester
    {
        public static void T_P16()
        {
            Page16.Mammal m = new Page16.Mammal();
            Type t1 = m.GetType();
            string birth = "method not found";

            var method = t1.GetMethod("GiveBirth");
            if (method == null)
            {
                Console.WriteLine("I can not find the GiveBirth method in Mammal, did you inherit from Animal?");
            }
            birth =( method?.Invoke(m,new object [0]) as string)??"";
            if (birth.ToLower() != "i give live birth")
            {
                if (birth.ToLower() == "i don't know how")
                {
                    Console.WriteLine("I can see that you created the 'Mammal' class. However, the call to 'GiveBirth' returns the same as what an 'Animal' would say. Did you override the method?");
                }
                else
                {
                    Console.WriteLine("I can see that you created the 'Mammal' class. However, the call to 'GiveBirth' does not return the proper string value. Did you override the method and return the text as described in the requirements?");
                }
               
            }

            Page16.Bird b = new Page16.Bird();
            Type t2 = b.GetType();
            birth = "method not found";

            method = t2.GetMethod("GiveBirth");
            if (method == null)
            {
                Console.WriteLine("I can not find the GiveBirth method in Bird, did you inherit from Animal?");
            }
            birth = (method?.Invoke(b, new object[0]) as string)??"";
            if (birth.ToLower() != "i lay eggs")
            {
                if (birth.ToLower() == "i don't know how")
                {
                    Console.WriteLine("I can see that you created the 'Bird' class. However, the call to 'GiveBirth' returns the same as what an 'Animal' would say. Did you override the method?");
                }
                else
                {
                    Console.WriteLine("I can see that you created the 'Bird' class. However, the call to 'GiveBirth' does not return the proper string value. Did you override the method and return the text as described in the requirements?");
                }
                return;
            }

            Console.WriteLine("Success. You did it!");

        }

        public static void T_P17()
        {

            Page17.Bird b = new Page17.Bird();
            Type t = b.GetType();
            var c = t.GetConstructor(new Type[] { typeof(string), typeof(bool) });
            if (c == null)
            {
                Console.WriteLine("Failure: I can not find the constructor that takes a string and a bool in the class Bird.  Did you uncomment lines 18 to 22 in Page17.cs");
                return;
            }
            b = (Page17.Bird)c.Invoke(new object[] { "Flappy", false });
            //new Page17.Bird("Flappy", false);
            var m = t.GetMethod("GiveBirth");
            if (m == null)
            {
                Console.WriteLine("Failure: I can not find the method GiveBirth that was supposed to be inherited from the class animal...Is it present and public?");
                return;
            }
            if (m.Invoke(b,new object[0]).ToString() != "eggs")
            {
                Console.WriteLine("Failure: I can see that you created the base class. However, the call to 'GiveBirth' is not returning the correct value for a 'Bird'. Check the requirements.  ");
                return;
            }

            Console.WriteLine("Success. You did it!");


        }
    }
}

