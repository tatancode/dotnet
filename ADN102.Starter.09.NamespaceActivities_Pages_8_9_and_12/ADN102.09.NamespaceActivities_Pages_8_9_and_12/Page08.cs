using System;
using ADN102._09.NamespaceActivities_Pages_8_9_and_12;

//Create a new public class named Auto with two public string properties: make and model.

//The Auto class should have a default constructor and a constructor that accepts two arguments,
//1 for each of the properties; make should be the first parameter, model the second

//The class should be contained within the Vehicles namespace.

//The Vehicles namespace should be contained within the Transportation namespace.

// be sure to activate Page08.Program.Main in the Program.cs file

namespace Page08
{
    public class Program
    {
        public static void Main()
        {
            // replace this 'new int()'  as a new instance of your Auto class
            Tester.Test_Page8(   new int()   );  
        }

    }
    
}

// create your auto class here:
namespace Transportation
{
    namespace Vehicles
    { 
        public class Auto
        {
            public string make { get; set; }
            public string model { get; set; }

            public Auto()
            {
                make = "Default make";
            }

            public Auto(string _make, string _model)
            {
                make = _make;
                model = _model;
            }
        }

    }
}


