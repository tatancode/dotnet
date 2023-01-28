using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Page05
{
    class Program
    {

        public static void Main1()
        {
            string[] colors;         // Step 1: the reference variable is created as an array of string.  
                                     // its name is colors.  
                                     // it is not currently connected to an actual array.
            colors = new string[4];   // Step 2: The array of string is created with 4 slots.  
                                      // the size is determined by the integer inside the [] which can be a literal
                                      // the size is fixed at 4 and cannot be changed after this line is executed.
            colors[0] = "Blue";       // load slot 0
            colors[1] = "Pink";       // load slot 1
            colors[2] = "Green";      // load slot 2
            colors[3] = "Yellow";     // load slot 3
            Console.WriteLine(colors[0]);  // causes "Blue" to appear
                                           // Outputs Blue
        }

        public static void Main2()
        {
            int size = 4;                // this is a variable of type integer which is 
                                         //assigned the initial value of 4
            string[] colors;            // Step 1:  the reference variable is created as an array of string.  
                                        // its name is colors.
                                        // it is not currently connected to an actual array.
            colors = new string[size];   // Step 2:  The array of string is created with [size] slots.  
                                         // since size is 4, the array has 4 slots
                                         // the size is determined by integer inside the [] which can be a variable
            colors[0] = "Blue";
            colors[1] = "Pink";
            colors[2] = "Green";
            colors[3] = "Yellow";
            Console.WriteLine(colors[0]);  // causes "Blue" to appear
                                           
        }

        public static void Main3()
        {
            string[] colors = { "Blue", "Pink", "Green", "Yellow" };
            // Step 1 and 2 are being done at the same time.
            // a reference variable called colors (which is an array of string) 
            // is created and being initialized
            // the size is determined by the number of elements in {}
            // the first element is placed in slot 0,
            //  and so on until all the slots are filled.
            Console.WriteLine(colors[0]);
            // Outputs Blue
        }

        public static void Main4()
        {
            string[] colors = { "Blue", "Pink", "Green", "Yellow" };
            Console.WriteLine(colors.Length); // causes "4" to appear because the array has 4 elements
                                              // Outputs 4

            foreach (string c in colors)
            {
                Console.Write(c);
                Console.Write(", ");
}
            //Outputs Blue, Pink, Green, Yellow, 
        }
    }
}
