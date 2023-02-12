using System;

namespace runTime
{   
    class Run
    {
        public static void Divide(int a, int b)
        {
            Console.WriteLine(a / b);
        }
        public static void Runner()
        {
            Divide(5, 0);
        }
    }
}
