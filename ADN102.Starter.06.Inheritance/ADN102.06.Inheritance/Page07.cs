using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Page07
{

    class black
    {
        public int a;
        public int b;
        public int c;
    }

    class purple : black
    {
        public int d;
        public int a;  // example of data hiding/shadowing  this a hide the one from black
    }

    class program
    {
        static void Main()
        {
            purple one = new purple();
            black two = one;
            one.a = 1;
            two.a = 2;

        }
    }
    
}
