using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Page14
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
        public mammal(string name) : base(name)
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
        public marsupial(string name) : base(name)
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
        public reptile(string name) : base(name)
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
            List<animal> animals = new List<animal>();
            animals.Add(new animal("sponge"));
            animals.Add(new animal("spider"));
            animals.Add(new reptile("turtle"));
            animals.Add(new mammal("rabbit"));
            animals.Add(new reptile("snake"));
            animals.Add(new mammal("zebra"));
            animals.Add(new marsupial("kangaroo"));
            animals.Add(new mammal("lion"));
            animals.Add(new marsupial("koala"));
            int i = 0;
            foreach (animal a in animals)
            {
                string title = $"animal {i++}";
                a.Eat(title);
                a.Reproduce(title);
            }
        }
    }

}
