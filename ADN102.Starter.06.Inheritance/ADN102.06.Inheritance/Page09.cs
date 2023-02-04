using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADN102._06.Inheritance
{
    class SomeChildType : SomeChildTypeParent
    {
        float childfield1;

        public SomeChildType()     // default child constructor.  matches SomeChildType t = new SomeChildType();
        {
            childfield1 = 2.212F;
        }

        // this is the constructor that matches  SomeChildType t = new SomeChildType(a,b,c);  where a is an integer, b is a float, and z is a string
        public SomeChildType(int x, float y, string z) : base(z, x)
        {
            // code to execute for the child class
            childfield1 = y;
        }
    }

    

    class SomeChildTypeParent : UltimateParent
    {
        int parentfield1;

        // this is the default constructor: it is called by default
        public SomeChildTypeParent() : base("SomeChildTypeParent data")
        {
            // this is a default ctor
            parentfield1 = 1000;
        }

        // this constructor is called by :base(z,x) where z is a string and x is an integer 
        public SomeChildTypeParent(string title, int count) : base(title.ToUpper())
        {
            parentfield1 = count;
        }
    }

    class UltimateParent
    {
        string ultimatefield;

        public UltimateParent(string data)
        {
            ultimatefield = data;
        }
    }


    class Page09
    {

        public static void Main()
        {
            int a = 10;
            float b = 3.14159f;
            string c = "default";

            SomeChildType t = new SomeChildType(a, b, c);

        }
    }
}
