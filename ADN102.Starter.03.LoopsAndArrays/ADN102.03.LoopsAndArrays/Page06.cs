
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Page06
{
    class Program
    {

        public static void Main1()
        {
            System.Collections.Generic.List<string> colors;
            // Step 1:  Create the reference variable called colors.  
            // This variable is able to be attached to any List<String>
            // notice that the fully qualified name of System.Collections.Generic.List<T>  
            //   (where T is string) was used
            colors = new System.Collections.Generic.List<String>(3);
            // Step 2:  A List of string with an initial capacity of 3 is created.  
            // The current count is 0
            // notice that the fully qualified name of System.Collections.Generic.List<T>  
            //    (where T is string) was used

            colors.Add("Blue");  // the capacity is 3 and the count is now 1
            colors.Add("Pink");  // the capacity is 3 and the count is now 2
            colors.Add("Green"); // the capacity is 3 and the count is now 3
            colors.Add( "Yellow"); // the new capacity is now 6 and the count is 4
            colors.TrimExcess();       // the new capacity is now 4 and the count is 4: 
                                  // the extra unused space was 'squeezed' out
            Console.WriteLine(colors[0]);  // causes "Blue" to appear
                                           // Outputs Blue
        }

        public static void Main2()
        {
           
            List<string> colors;
            // Step 1:  Create the reference variable called colors.  
            // This variable is able to be attached to any List<String>
            // notice that the name of List<T>  (where T is string) was used 
            // and the System.Collections.Generic was able to be omitted
            colors = new List<String>(3);
            // Step 2:  A List of string with an initial capacity of 3 is created.  
            // The current count is 0
            // notice that the name of List<T>  (where T is string) was used and 
            // the System.Collections.Generic was able to be omitted

            colors.Add("Blue");  // the capacity is 3 and the count is now 1
            colors.Add("Pink");  // the capacity is 3 and the count is now 2
            colors.Add("Green"); // the capacity is 3 and the count is now 3
            colors.Add("Yellow"); // the new capacity is now 6 and the count is 4
            colors.TrimExcess();        // the new capacity is now 4 and the count is 4: 
                                  // the extra unused space was 'squeezed' out
            Console.WriteLine(colors[0]);  // causes "Blue" to appear
                                           // Outputs Blue
        }

        public static void Main3()
        {
            List<string> colors;
            // Step 1:  Create the reference variable called colors. 
            //  This variable is able to be attached to any List<String>
            // notice that the name of List<T>  (where T is string) was used 
            // and the System.Collections.Generic was able to be omitted
            colors = new List<String>() { "Blue", "Pink", "Green", "Yellow", "Orange" };
            // Step 2:  A List of string with an initial capacity of 4 is created, 
            // it was doubled to 8.  The current count is 5
            // notice that the name of List<T>  (where T is string) was used 
            // and the System.Collections.Generic was able to be omitted
            // notice that the list can be initialized just like an array


            Console.WriteLine(colors[0]);  // causes "Blue" to appear
            Console.WriteLine(colors.Capacity);
            Console.WriteLine(colors.Count);
            // Outputs Blue
        }

        public static void Main4()
        {
            List<string> colors;
            // Step 1:  Create the reference variable called colors.  
            // This variable is able to be attached to any List<String>
            // notice that the name of List<T>  (where T is string) was used 
            // and the System.Collections.Generic was able to be omitted
            colors = new List<String>() { "Blue", "Pink", "Green", "Yellow", "Orange" };
            // Step 2:  A List of string with an initial capacity of 3 is created.  
            // The current count is 0
            // notice that the name of List<T>  (where T is string) was used 
            // and the System.Collections.Generic was able to be omitted
            // notice that the list can be initialized just like an array


            for (int i = 0; i < colors.Count; i++)
            {
                Console.WriteLine(colors[i]);
            }

            foreach (string c in colors)
            {
                Console.WriteLine(c);
            }
        }
    }
}
