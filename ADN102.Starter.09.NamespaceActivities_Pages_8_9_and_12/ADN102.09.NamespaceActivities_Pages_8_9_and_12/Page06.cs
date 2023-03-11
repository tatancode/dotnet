using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// these examples have been slightly changed in order to place them all in a single file.
// the actual namespaces have been changed by adding a number to the end

namespace Page06
{
    namespace csharpNamespace
    {
        // Program start class
        class Program
        {
            // Main begins program execution.
            public static void Main()
            {
                // Write to console
                Console.WriteLine("This is the new C# Namespace.");
            }
        }
    }


    namespace csharpNamespace1
    {
        // The new Namespace
        namespace newNamespace
        {
            // Program start class
            class Program
            {
                // Main begins program execution.
                public static void Main()
                {
                    // Write to console
                    Console.WriteLine("This is the new Namespace.");
                }
            }
        }
    }

    namespace csharpNamespace2.newNamespace
    {
        // Program start class
        class Program
        {
            // Main begins program execution.
            public static void Main()
            {
                // Write to console
                Console.WriteLine("This is the new Namespace.");
            }
        }
    }

    namespace csharpNamespace3
    {
        // nested namespace
        namespace newNamespace
        {
            class myExample
            {
                public static void print()
                {
                    Console.WriteLine("Calling another namespace member.");
                }
            }
        }

        // Program start class
        class Program
        {
            // Main begins program execution.
            public static void Main()
            {
                // Write to console
                csharpNamespace3.newNamespace.myExample.print();         // defined above
                csharpNamespace3.newNamespace.newExample.newPrint();     // defined below
            }
        }
    }

    namespace csharpNamespace3.newNamespace
    {
        class newExample
        {
            public static void newPrint()
            {
                Console.WriteLine("Second Example of calling another namespace member.");
            }
        }
    }


}
