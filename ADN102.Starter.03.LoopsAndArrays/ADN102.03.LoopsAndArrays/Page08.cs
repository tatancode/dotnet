using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Page08
{
    class Program
    {
        public static void show(string [] array)
        {
            Console.WriteLine($"array.Length: {array.Length}");
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"array[{i}] = '{array[i]}'");
            }
        }

        public static void Main1()
        {
            string data = "zero, one ,  two  , \t three \t ";

            string[] items = data.Split();
            show(items);

        }

        public static void Main2()
        {
            string data = "zero, one ,,  two  ,,, \t three \t ";
            string[] items = data.Split(',');
            show(items);

        }

        public static void Main3()
        {
            string data = "zero, one ,,  two  ,,, \t three \t ";
            string[] items = data.Split(',', StringSplitOptions.RemoveEmptyEntries);
            show(items);

        }

        public static void Main4()
        {
            string data = "zero, one ,,  two  ,,, \t three \t ";
            string[] items = data.Split(',', StringSplitOptions.TrimEntries);
            show(items);
        }

        public static void Main5()
        {
            string data = "zero, one ,,  two  ,,, \t three \t ";
            string[] items = data.Split(',',
              StringSplitOptions.TrimEntries | StringSplitOptions.RemoveEmptyEntries);
            show(items);
        }

        public static void Main6()
        {
            string data = "zero, one ,,  two  ,,, \t three \t ";
            string[] items = data.Split(',', ' ', '\t');
            show(items);

        }

        public static void Main7()
        {
            string data = "zero, one ,,  two  ,,, \t three \t ";
            string[] items = data.Split(", \t");
            show(items);
        }

    }
}
