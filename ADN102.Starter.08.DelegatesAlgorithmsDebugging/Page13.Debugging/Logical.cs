using System;

namespace logical
{   
    class Logic
    {
        public static void SomeLogic()
        {
            int startingValue = 21;
            int endingValue = 1;
            int value = 0;

            for (int i = startingValue; i < endingValue; i++)
            {
                value = value + i;
            }

            Console.WriteLine("The answer is: " + value.ToString());
        }
    }
}
