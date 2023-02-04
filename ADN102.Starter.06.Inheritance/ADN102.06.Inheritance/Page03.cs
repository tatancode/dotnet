using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Page03
{
    class black
    {
        public int b1;
        protected int b2;
        private int b3;
    }
    class orange : black
    {
        public int o1;
        protected int o2;
    }
    class green : orange
    {
        public int g1;
    }
    class purple : black
    {
        public int p1;
    }
    class Program
    {
        static public void mainblack()
        {
            black one;
            black two = new black();
            object three = two;
        }

        static public void mainorange()
        {
            orange one;
            orange two = new orange();
            black three = two;
            object four = two;
        }

        static public void maingreen()
        {
            green one;
            green two = new green();
            orange three = two;
            black four = two;
            object five = two;
        }

        static public void mainpurple()
        {
            purple one;
            purple two = new purple();
            black three = two;
            object four = two;
        }

    }

}
