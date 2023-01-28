using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Page08
{
    class Program
    {
        public static void Main1(string [] args)
        {
            Console.WriteLine($"Processing {args.Length} files");
            foreach(string fn in args)
            {
                Console.WriteLine($"Processing file { fn}");
            }
        }

        public static void Main2()
        {
            int[] a = new int[] { 1, 3, 5, 7, 11, 13 };

            AddThemAll("an array", 111, a);
            //(title = "an array", start = 111, rest = the array named a)

            AddThemAll("zero extra elements", 10);
            // (title= "zero extra elements", start =10, rest = new int[0]);  rest = 0 element array)
            AddThemAll("one extra element", 20, 1);
            // (title= "one extra element", start = 20, rest = new int[] {1}); rest = 1 element array)
            AddThemAll("three extra elements", 80, 1, 3, 7);
            //(title= "three extra elements", start = 80, rest = new int[] {1, 3, 7}); rest = 3 element array)
            AddThemAll("ten Extra elements", 100, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10);
            //(title= "ten extra elements", start = 100 and rest = 10 element array)
        }

        static int AddThemAll(string title, int start, params int[] rest)
        {
            Console.WriteLine($"Start is {start}");
            foreach (int x in rest)
            {
                Console.WriteLine($"Processing item {x}, new total is {start}");
                start = start + x;
            }

            Console.WriteLine($"{title}:{start}");
            return start;
        }

    }
}
