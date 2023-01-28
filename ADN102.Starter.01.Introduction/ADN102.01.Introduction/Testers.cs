using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADN102._01.Introduction
{
    class Testers
    {
        public static void Directions()
        {
            Console.WriteLine("Edit the file 'Program.cs' and 'uncomment' out the information");
            Console.WriteLine("For the Page you are working on.  Comment out all the other lines");
        }
        public static void Test_all()
        {
            string[] args = null;
            Console.WriteLine("***********Begin Page 20 ****************");
            T_P20();
            Console.WriteLine("***********Begin Page 21 ****************");
            T_P21();
            Console.WriteLine("***********Begin Page 22 ****************");
            T_P22();
            Console.WriteLine("***********Begin Page 24 ****************");
            T_P24();
            Console.WriteLine("***********Begin Page 25 ****************");
            T_P25();

        }
        public static void T_P20()
        {
            string[] args = null;
            object rv = Page20.Program.StudentMain(args);
            if ((25).GetType() != rv.GetType())
            {
                Console.WriteLine($"Failed, You did not return an integer, instead you returned an {rv.GetType().Name}");
                return;
            }
            if (rv.Equals(25))
            {
                Console.WriteLine("Success, I observed the value of 25");
            }
            else
            {
                Console.WriteLine("Failed, you returned an integer, but I did not observe the value of 25");
            }
        }

        public static void T_P21()
        {
            object rv = Page21.Program.StudentMain(1, 2);
            if (("Test").GetType() != rv.GetType())
            {
                Console.WriteLine($"Failed, You did not return a string, instead you returned an {rv.GetType().Name}");
                return;
            }
            string expected = "parameterOne has a value of '1' and parameterTwo has a value of '2', Adding the two together gives a total value of '3'!";
            if (rv.Equals(expected))
            {
                Console.WriteLine("Success, Called with 1,2 and I observed the value of 'parameterOne has a value of '1' and parameterTwo has a value of '2', Adding the two together gives a total value of '3'!");
            }
            else
            {
                Console.WriteLine("Failed, you returned a string, but I expected value of :<br>");
                Console.WriteLine($"{expected}<br>Instead I observed the value of: <br>");
                Console.WriteLine(rv);
            }
        }

        public static void T_P22()
        {
            object rv = Page22.Program.StudentMain();
            if ((Math.PI).GetType() != rv.GetType())
            {
                Console.WriteLine($"Failed, You did not return a double, instead you returned an {rv.GetType().Name}");
                return;
            }
            if (rv.Equals(Math.PI / 2))
            {
                Console.WriteLine($"Success, You gave me {rv} and I was Expecting {Math.PI / 2}");
            }
            else
            {
                if (Math.Abs(((double)rv) - Math.PI / 2) > .00001)
                {
                    Console.WriteLine($"Failed, you returned a double, but You gave me {rv} and I was Expecting {Math.PI / 2}");
                }
                else
                {
                    Console.WriteLine($"Success, You gave me {rv} and I was Expecting {Math.PI / 2}, but your value was close enough");
                }

            }
        }

        public static void T_P24()
        {
            int i;
            i = 3;
            object rv = Page24.Program.StudentMain(i);
            if (("test").GetType() != rv.GetType())
            {
                Console.WriteLine($"Failed, for the number {i}, You did not return a string, instead you returned an {rv.GetType().Name}");
                return;
            }
            if (rv.Equals("ODD"))
            {
                Console.WriteLine($"Success, for the number {i}, You gave me {rv} and I was Expecting ODD<br>");
            }
            else
            {
                Console.WriteLine($"Failed, for the number {i}, You gave me {rv} and I was Expecting ODD<br>");
                return;
            }
            i = 13;
            rv = Page24.Program.StudentMain(i);
            if (("test").GetType() != rv.GetType())
            {
                Console.WriteLine($"Failed, for the number {i}, You did not return a string, instead you returned an {rv.GetType().Name}");
                return;
            }
            if (rv.Equals("ODD"))
            {
                Console.WriteLine($"Success, for the number {i}, You gave me {rv} and I was Expecting ODD<br>");
            }
            else
            {
                Console.WriteLine($"Failed, for the number {i}, You gave me {rv} and I was Expecting ODD<br>");
                return;
            }
            i = 47;
            rv = Page24.Program.StudentMain(i);
            if (("test").GetType() != rv.GetType())
            {
                Console.WriteLine($"Failed, for the number {i}, You did not return a string, instead you returned an {rv.GetType().Name}");
                return;
            }
            if (rv.Equals("ODD"))
            {
                Console.WriteLine($"Success, for the number {i}, You gave me {rv} and I was Expecting ODD<br>");
            }
            else
            {
                Console.WriteLine($"Failed, for the number {i}, You gave me {rv} and I was Expecting ODD<br>");
                return;
            }
            i = 6;
            rv = Page24.Program.StudentMain(i);
            if (("test").GetType() != rv.GetType())
            {
                Console.WriteLine($"Failed, for the number {i}, You did not return a string, instead you returned an {rv.GetType().Name}");
                return;
            }
            if (rv.Equals("EVEN"))
            {
                Console.WriteLine($"Success, for the number {i}, You gave me {rv} and I was Expecting EVEN<br>");
            }
            else
            {
                Console.WriteLine($"Failed, for the number {i}, You gave me {rv} and I was Expecting EVEN<br>");
                return;
            }

            i = 18;
            rv = Page24.Program.StudentMain(i);
            if (("test").GetType() != rv.GetType())
            {
                Console.WriteLine($"Failed, for the number {i}, You did not return a string, instead you returned an {rv.GetType().Name}");
                return;
            }
            if (rv.Equals("EVEN"))
            {
                Console.WriteLine($"Success, for the number {i}, You gave me {rv} and I was Expecting EVEN<br>");
            }
            else
            {
                Console.WriteLine($"Failed, for the number {i}, You gave me {rv} and I was Expecting EVEN<br>");
                return;
            }
            i = 24680;
            rv = Page24.Program.StudentMain(i);
            if (("test").GetType() != rv.GetType())
            {
                Console.WriteLine($"Failed, for the age {i}, You did not return a string, instead you returned an {rv.GetType().Name}");
                return;
            }
            if (rv.Equals("EVEN"))
            {
                Console.WriteLine($"Total Success, for the age {i}, You gave me {rv} and I was Expecting EVEN<br>");
            }
            else
            {
                Console.WriteLine($"Failed, for the age {i}, You gave me {rv} and I was Expecting EVEN<br>");
                return;
            }

        }

        public static void T_P25()
        {
            object rv = Page25.Program.StudentMain(3);
            if (("test").GetType() != rv.GetType())
            {
                Console.WriteLine($"Failed, for the age 3, You did not return a string, instead you returned an {rv.GetType().Name}");
                return;
            }
            if (rv.Equals("Cinderella"))
            {
                Console.WriteLine($"Success, for the age 3, You gave me {rv} and I was Expecting Cinderella");
            }
            else
            {
                Console.WriteLine($"Failed, for the age 3, You gave me {rv} and I was Expecting Cinderella");
                return;
            }

            rv = Page25.Program.StudentMain(10);
            if (("test").GetType() != rv.GetType())
            {
                Console.WriteLine($"Failed, for the age 10, You did not return a string, instead you returned an {rv.GetType().Name}");
                return;
            }
            if (rv.Equals("Home Alone"))
            {
                Console.WriteLine($"Success, for the age 10, You gave me {rv} and I was Expecting Home Alone");
            }
            else
            {
                Console.WriteLine($"Failed, for the age 10, You gave me {rv} and I was Expecting Home Alone");
                return;
            }

            rv = Page25.Program.StudentMain(15);
            if (("test").GetType() != rv.GetType())
            {
                Console.WriteLine($"Failed, for the age 15, You did not return a string, instead you returned an {rv.GetType().Name}");
                return;
            }
            if (rv.Equals("Jurassic Park"))
            {
                Console.WriteLine($"Success, for the age 15, You gave me {rv} and I was Expecting Jurassic Park");
            }
            else
            {
                Console.WriteLine($"Failed, for the age 15, You gave me {rv} and I was Expecting Jurassic Park");
                return;
            }

            rv = Page25.Program.StudentMain(20);
            if (("test").GetType() != rv.GetType())
            {
                Console.WriteLine($"Failed, for the age 20, You did not return a string, instead you returned an {rv.GetType().Name}");
                return;
            }
            if (rv.Equals("The Terminator"))
            {
                Console.WriteLine($"Total Success, for the age 20, You gave me {rv} and I was Expecting The Terminator");
            }
            else
            {
                Console.WriteLine($"Failed, for the age 20, You gave me {rv} and I was Expecting The Terminator");
                return;
            }

        }
    }
}
