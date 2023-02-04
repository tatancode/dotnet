using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Page03;

namespace Page05
{
    class Program
    {
        public static void Main()
        {
            green one = new green();
            black two = one;
            orange three;
            purple four;
           // three = two;
            three = (orange)two;
            four = (purple)two;
            three = two as orange;
            four = two as purple;
            bool test = two is orange;
            bool test2 = two is purple;

        }
    }
}
