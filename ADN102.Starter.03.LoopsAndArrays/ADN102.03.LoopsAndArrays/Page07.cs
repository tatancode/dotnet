using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Page07
{
    class Program
    {
        public static void Main1()
        {
            System.Collections.Generic.Dictionary<string, int> Numbers;
            // Step 1:  Create the reference variable called Numbers.  
            // This variable is able to be attached to any Dictionary<int,string>
            // notice that the fully qualified name of System.Collections.Generic.Dictionary<K,V>  
            // (where K is string and V is int) was used
            Numbers = new System.Collections.Generic.Dictionary<string, int>();
            // Step 2:  A Dictionary is created
            // notice that the fully qualified name of System.Collections.Generic.Dictionary<K,V>  
            // (where K is string and V is int) was used

            Numbers.Add("One", 1);
            Numbers.Add("Two", 2);
            Numbers.Add("Three", 3);
            Numbers.Add("Four", 4);
            bool worked = Numbers.TryAdd("Five", 5);  // succeeds and returns true into the variable worked
            worked = Numbers.TryAdd("One", 100);  // fails because the key "One" is already assigned to 1,
                                                  // so false is returned into the variable worked

            Console.WriteLine(Numbers["Three"]);  // causes "3" to appear
                                                  // Outputs 3
        }

        public static void Main2()
        {
            Dictionary<string, int> Numbers;
            // Step 1:  Create the reference variable called Numbers.  
            // This variable is able to be attached to any Dictionary<int,string>
            // notice that the name of Dictionary<K,V> 
            // (where K is string and V is int) was used and the 
            // System.Collections.Generic was able to be omitted
            Numbers = new Dictionary<string, int>();
            // Step 2:  A Dictionary is created
            // notice that the name of Dictionary<K,V>  
            // (where K is string and V is int) was used and the 
            // System.Collections.Generic was able to be omitted
            Numbers.Add("One", 1);
            Numbers.Add("Two", 2);
            Numbers.Add("Three", 3);
            Numbers.Add("Four", 4);
            bool worked = Numbers.TryAdd("Five", 5);  // succeeds and returns true into the variable worked
            worked = Numbers.TryAdd("One", 100);  // fails because the key "One" is already assigned to 1,
                                                  // so false is returned into the variable worked

            Console.WriteLine(Numbers["Three"]);  // causes "3" to appear
                                                  // Outputs 3
        }

        public static void Main3()
        {
            Dictionary<string, int> Numbers;
            // Step 1:  Create the reference variable called Numbers. 
            // This variable is able to be attached to any Dictionary<int,string>
            // notice that the name of Dictionary<K,V>  (where K is string and V is int) was used and the 
            // System.Collections.Generic was able to be omitted
            Numbers = new Dictionary<string, int>() { { "One", 1 }, { "Two", 2 }, { "Three", 3 }, { "Four", 4 } };
            // Step 2:  A Dictionary is created
            // notice that the name of Dictionary<K,V>  (where K is string and V is int) was used and the 
            // System.Collections.Generic was able to be omitted

            bool worked = Numbers.TryAdd("Five", 5);  // succeeds and returns true into the variable worked
            worked = Numbers.TryAdd("One", 100);  // fails because the key "One" is already assigned to 1, 
                                                  //so false is returned into the variable worked

            Console.WriteLine(Numbers["Three"]);  // causes "3" to appear
                                                  // Outputs 3
        }

        public static void Main4()
        {
            Dictionary<string, int> Numbers;
            // Step 1:  Create the reference variable called Numbers.  
            // This variable is able to be attached to any Dictionary<int,string>
            // notice that the name of Dictionary<K,V>  (where K is string and V is int) was used and the 
            // System.Collections.Generic was able to be omitted
            Numbers = new Dictionary<string, int>() { { "One", 1 }, { "Two", 2 }, { "Three", 3 }, { "Four", 4 } };
            // Step 2:  A Dictionary is created
            // notice that the name of Dictionary<K,V>  (where K is string and V is int) was used and the 
            // System.Collections.Generic was able to be omitted

            bool worked = Numbers.TryAdd("Five", 5);  // succeeds and returns true into the variable worked
            worked = Numbers.TryAdd("One", 100);  // fails because the key "One" is already assigned to 1, 
                                                  // so false is returned into the variable worked

            foreach (string k in Numbers.Keys)  // Numbers.Keys is a collection of all the keys to the Dictionary
            {
                Console.WriteLine(Numbers[k]);  // the Numbers Dictionary can be accessed like an array using the Key
            }

            foreach (KeyValuePair<string,int> kvp in Numbers)   // Numbers is a collection and when 
                                                    // iterating will provide a KeyValuePair 
                                                    // containing both the Key and the Value
            {
                Console.WriteLine($"The Key is '{kvp.Key}' and the Value is '{kvp.Value}'");
                // kvp is the KeyValuePair
            }

            // Outputs 3
        }
    }
}
