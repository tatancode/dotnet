using System;
using MyNamespace;
using MyNamespace.MyObjects;

//In the Test class, create a method named TestWidget that accepts a single Widget object as a parameter
//and increments the object's 'viewed' property by 1. This method returns nothing (void).

// The Widget class is defined below

// be sure to activate Tester.Test_Page9() in the Program.cs file

namespace MyNamespace
{
    namespace MyObjects
    {
        public class Widget
        {
            public int viewed;

            public Widget()
            {
                this.viewed = 0;
            }
        }
    }
}

namespace Exercise
{

    public class Test
    {
        // TODO: implement the 'TestWidget` method here
         
        public void TestWidget(Widget _widget)
        {
            _widget.viewed++;
        }
       
    }
}

