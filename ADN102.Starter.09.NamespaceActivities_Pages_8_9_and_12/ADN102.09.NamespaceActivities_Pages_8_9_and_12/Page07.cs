using Page07.csharpNamespace;
using aliasName = Page07.csharpNamespace.myExample;
using C = System.Console;

using static System.Math;                  // using static allows access to all STATIC members of the class
using static System.Console;

namespace Page07
{
    class UsingDirectives
    {
        public static void Main()
        {
            myExample.print();  // understood because line 1: myExample is in Page07.csharpNamespace
            aliasName.print();  // understood because line 2: aliasName is another name for Page07.csharpNamespace.MyExample

            Sqrt(3*3 + 4*4);    // understood because line 5: All static members of the Math class are available
        }
    }

    namespace csharpNamespace
    {
        class myExample
        {
            public static void print()
            {
                C.WriteLine("Example of using a using directive.");  // understood because line 3:
                                                                     //     C is another name for System.Console
                WriteLine("Hello");                                  // understood because line 6:
                                                                     //     All static members of the Console class are available
            }
        }
    }
}
