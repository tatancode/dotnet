using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADN102._02.Operations
{
    class Testing
    {
        public static void Directions()
        {
            Console.WriteLine("Edit the file 'Program.cs' and 'uncomment' out the information");
            Console.WriteLine("For the Page you are working on.  Comment out all the other lines");
        }
        public static void Test_All()
        {
            Test_Page7();
            Test_Page8();
            Test_Page10();
            Test_Page11();
            Test_Page20();
            Test_Page21();
        }

        public static void Test_Page7()
        {
            Console.WriteLine("*****Testing Page7******");
            var student = new Page7.StudentCode();
            var result = student.CheckEverything();
            if (result == true)
            {
                Console.WriteLine("Success. You did it!");
            }
            else
            {
                Console.WriteLine("Failed");
            }
        }

        public static void Test_Page8()
        {
            Console.WriteLine("*****Testing Page8******");
            var si = new Page8.StudentInput();
            bool test = si.studentCanWatch(18, false);
            if (test == false)
            {
                Console.WriteLine("There is a problem with your logic. For a student that is 18 and without a parent, the result of the call to 'studentCanWatch' should be 'true', but it is 'false'.");
                return;
            }

            test = si.studentCanWatch(13, true);
            if (test == false)
            {
                Console.WriteLine("There is a problem with your logic. For a student that is 13 and with a parent, the result of the call to 'studentCanWatch' should be 'true', but it is 'false'.");
                return;
            }

            test = si.studentCanWatch(17, false);
            if (test == true)
            {
                Console.WriteLine("There is a problem with your logic. For a student that is 17 and without a parent, the result of the call to 'studentCanWatch' should be 'false', but it is 'true'.");
                return;
            }

            test = si.studentCanWatch(12, true);
            if (test == true)
            {
                Console.WriteLine("There is a problem with your logic. For a student that is 12 and with a parent, the result of the call to 'studentCanWatch' should be 'false', but it is 'true'.");
                return;
            }

            Console.WriteLine("Success. You did it!");

        }

        public static void Test_Page10()
        {
            Console.WriteLine("*****Testing Page10******");
            var p = new Page10.Product();
            double cents = p.newPayments(131.25, 236.23);
            if (cents == 36748)
            {
                Console.WriteLine("Success. You did it!");
            }
            else if (cents == 23754.25)
            {
                Console.WriteLine("I can see that you added logic for the arithmetic in 'newPayments'. However, it's returning the incorrect value. Did you sum the 'cost' and 'deliveryFee' before multiplying by 100? Remember, you can use parentheses to control the order of operations.");
            }
            else
            {
                Console.WriteLine("The 'newPayments' method is not returning the correct value. Remember, you are adding the two values and returning the total in cents.");
            }
        }

        public static void Test_Page11()
        {
            Console.WriteLine("*****Testing Page11******");
            var m = new Page11.DoMath();
            double avg = m.getAverage(1.1, 3.3);
            if (avg == 2.2)
            {
                Console.WriteLine("Success. You did it!");
            }
            else if (avg == 2.75)
            {
                Console.WriteLine("I can see that you added logic for the arithmetic in 'getAverage'. However, it's returning the incorrect value. Did you forget the parentheses?");
            }
            else
            {
                Console.WriteLine("The 'getAverage' method is not returning the correct value. Remember, to get the average, you first sum the variables and then divide by the count.");
            }
        }

        public static void Test_Page20()
        {
            Console.WriteLine("*****Testing Page20******");
            var s = new Page20.Student();
            string fullName = s.getFullName("Bill", "Coder");
            if (fullName == "Bill Coder")
            {
                Console.WriteLine("Success. You did it!");
            }
            else if (fullName == "Bill")
            {
                Console.WriteLine("There is a problem with your logic. It appears that the 'studentName' method is returning only the first name. Did you concatenate the first and last names with a space in between?");
            }
            else if (fullName == "Coder")
            {
                Console.WriteLine("There is a problem with your logic. It appears that the 'studentName' method is returning only the last name. Did you concatenate the first and last names with a space in between?");
            }
            else if (fullName == "BillCoder")
            {
                Console.WriteLine("There is a problem with your logic. It appears that the 'studentName' method is returning the full name without a space in between.");
            }
            else
            {
                Console.WriteLine("There is a problem with your logic. Did you concatenate the first and last names with a space in between?");
            }
        }

        public static void Test_Page21()
        {
            Console.WriteLine("*****Testing Page21******");
            var s = new Page21.Strings();
            bool resultTrue = s.doesLengthMatch("bill", 4);
            bool resultFalse = s.doesLengthMatch("sally", 4);
            if (resultTrue == true && resultFalse == false)
            {
                Console.WriteLine("Success. You did it!");
            }
            else
            {
                Console.WriteLine("There is a problem with your logic. Are you comparing the length of the 'source' string variable with the 'count' variable?");
            }
        }
    }
}
