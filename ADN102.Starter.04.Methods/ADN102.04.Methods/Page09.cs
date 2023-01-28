using System;
namespace Page9
{
    // See if you can correct the compiler errors, and get the code to compile.

    // instructions:  uncomment lines 11-12 and line 17.
    // correct all the errors and run the program
    public class StudentProgram
    {
        public static void StudentMain()
        {
            int x = (int) Hypotenuse(10.0, 20.0);
            Console.WriteLine(x);
        }

        static double Hypotenuse(double a, double b)
        {
            return Math.Sqrt(a * a - b * b);
            return 0;

        }
    }
    
}
