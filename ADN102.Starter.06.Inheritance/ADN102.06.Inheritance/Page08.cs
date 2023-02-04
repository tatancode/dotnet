using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Page8
{

    class animal
    {
        public string Name { get; set; }
        public animal()
        {
            Name = "Default";
            Console.WriteLine($"Create a default animal");
        }
        public animal(string name)
        {
            Name = name;
            Console.WriteLine($"Create a named animal called {Name}");
        }

        public void Eat(string title) { Console.WriteLine($"{title}>{Name} eats like an ANIMAL"); }
        public virtual void Reproduce(string title)
        {
            Console.WriteLine($"{title}>{Name} reproduces like an ANIMAL");
        }
    }

    class mammal : animal
    {

        public mammal()
        {
            Name = "Mammal Default";
            Console.WriteLine($"Create a default mammal");
        }
        public mammal(string name) 
        {
            Name = name;
            Console.WriteLine($"Create a named mammal called {Name}");
        }
        public void Eat(string title) { Console.WriteLine($"{title}>{Name} eats like a MAMMAL"); }
        public override void Reproduce(string title)
        {
            Console.WriteLine($"{title}>{Name} reproduces like a MAMMAL with live birth");
        }
    }

    class marsupial : mammal
    {

        public marsupial()
        {
            Name = "marsupial Default";
            Console.WriteLine($"Create a default marsupial");
        }
        public marsupial(string name) 
        {
            Name = name;
            Console.WriteLine($"Create a named marsupial called {Name}");
        }
        public override void Reproduce(string title)
        {
            Console.WriteLine($"{title}>{Name} reproduces like a marsupial in a pouch");
        }

    }

    class reptile : animal
    {
        public reptile()
        {
            Name = "reptile Default";
            Console.WriteLine($"Create a default reptile");
        }
        public reptile(string name) 
        {
            Name = name;
            Console.WriteLine($"Create a named reptile called {Name}");
        }
        public void Eat(string title) { Console.WriteLine($"{title}>{Name} eats like a REPTILE"); }
        public override void Reproduce(string title)
        {
            Console.WriteLine($"{title}>{Name} reproduces like a REPTILE with Eggs");
        }

    }

    class ZooProgram
    {
        public static void Main()
        {
            animal a;
            mammal mam;
            marsupial mar;
            reptile r;

            mar = new marsupial("mar");
            mam = mar;
            a = mar;
            // r = mar;

            a.Eat("a");
            mam.Eat("mam");
            mar.Eat("mar");

            a.Reproduce("a");
            mam.Reproduce("mam");
            mar.Reproduce("mar");
        }
    }

}
