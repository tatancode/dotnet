using System;
namespace Page7
{

    public class hello
    {
        public void sayhello()
        {
            Console.WriteLine("hello there!");
        }
        public int screamhello(int i)
        {
            Console.WriteLine($"HELLO THERE {i} times");
            return 2 * i;
        }
    }
    public class goodbye
    {
        public string Name { get; set; }
        public void saygoodbye()
        {
            Console.WriteLine($"goodbye {Name}");
        }
        public int screamgoodbye(int c)
        {
            Console.WriteLine($"GOODBYE {Name.ToUpper()} {c} times");
            return 10 * c;
        }
    }

    public class ouch
    {
        public string Perp { get; set; }
        public string Victim { get; set; }

        public mydelegate Phase1;
        public stillanotherdelegate Phase2;
        public event stillanotherdelegate Phase3;
        public event mydelegate Phase4;
        public void sayouch()
        {
            Console.WriteLine($"{Perp} Breaths on {Victim}");
        }
        public int screamouch(int count)
        {
            // phase 1 - encountered exactly one time BEFORE the looping
            if (Phase1 != null) Phase1();
            for (int i = 1; i <= count; i++)
            {
                // phase 2 - encountered count times - BEFORE each writeline
                if (Phase2 != null) Phase2(i, count);
                Console.WriteLine($"{Perp} Breaths on {Victim} time {i} of {count}");  // process this loop
                // phase 3 - encountered count times AFTER each writeline
                if (Phase3 != null) Phase3(i, count);
            }
            // phase 4 - encountered exactly one time AFTER the looping
            Phase4?.Invoke();
            return count;
        }
    }
    public delegate void mydelegate();
    public delegate int myotherdelegate(int count);
    public delegate void stillanotherdelegate(int current, int total);

    public class Program
    {


        public static void Main()
        {
            //step 1: declare the reference variables
            hello h;
            goodbye g1;
            goodbye g2;
            ouch o;

            // step 2: Attach the references to instances
            h = new hello();
            g1 = new goodbye(); // or = new goodbye() {Name = "Brian"};
            g2 = new goodbye(); // or = new goodbye() {Name = "Carol"};
            o = new ouch(); //or = new ouch() { Perp = "Daniel", Victim = "Lydia" };

            // step 3: Configure the instances (this can also be part of step 2 as seen above)
            g1.Name = "Brian";
            g2.Name = "Carol";
            o.Perp = "Daniel";
            o.Victim = "Lydia";

            // step 4: Exercise the instances

            //h.sayhello();
            //h.screamhello(3);
            //g1.saygoodbye();
            //g2.saygoodbye();
            //g1.screamgoodbye(4);
            //g2.screamgoodbye(5);
            //o.sayouch();
            //o.screamouch(5);

            //mydelegate d1 = new mydelegate(h.sayhello);
            //mydelegate d2 = new mydelegate(g1.saygoodbye);
            //mydelegate d3 = new mydelegate(g2.saygoodbye);
            //mydelegate d4 = new mydelegate(o.sayouch);

            //test(d1);
            //test(d2);
            //test(d3);
            //test(d4);


            //// add additional delegates here
            //myotherdelegate od1 = new myotherdelegate(h.screamhello);
            //myotherdelegate od2 = new myotherdelegate(g1.screamgoodbye);
            //myotherdelegate od3 = new myotherdelegate(g2.screamgoodbye);
            //myotherdelegate od4 = new myotherdelegate(o.screamouch);

            //test(od1);
            //test(od2);
            //test(od3);
            //test(od4);

            //mydelegate d1 = h.sayhello;

            //d1 += g1.saygoodbye;
            //d1 += g2.saygoodbye;
            //d1 += o.sayouch;
            //d1 += g2.saygoodbye;   // new line
            //d1 += g1.saygoodbye;   // new line

            //test(d1);              // changed back to test(d1) from test(o.screamouch)

            //d1 -= g2.saygoodbye;   // REMOVE a call to g2.saygoodbye

            //test(d1);               // verify that it was removed

            //d1 -= g1.saygoodbye;   // REMOVE a call to g1.saygoodbye

            //test(d1);              // verify it was removed
            Console.WriteLine("Starting Execution in Program.Main");

            Console.WriteLine("Registering Phase1");
            o.Phase1 += o_Phase1;
            o.Phase2 += XXX;
            o.Phase3 += O_Phase3;



            Console.WriteLine("Getting ready to call into o.ScreamOuch(5)");

            o.screamouch(5);

            Console.WriteLine("Done calling o.ScreamOuch(5)");

            Console.WriteLine("Exiting from Program.Main");
        }

        private static void O_Phase3(int current, int total)
        {
            //throw new NotImplementedException();
            Console.WriteLine($"Program.O_Phase3 was invoked.   current= {current} and total = {total}");
        }

        static void XXX(int a, int b)
        {
            Console.WriteLine($"Program.XXX was invoked.   a= {a} and b = {b}");
        }
        static void o_Phase1()
        {
            Console.WriteLine("Program.o_Phase1 was invoked");
        }
        // this is the previous test
        static void test(mydelegate d)
        {
            Console.WriteLine("Before");
            d();
            Console.WriteLine("After");
        }
        // this is a new **overload** of test.  there are now 2 test methods
        static void test(myotherdelegate d)
        {
            Console.WriteLine("Before");
            d(5);
            Console.WriteLine("After");
        }
    }
}
