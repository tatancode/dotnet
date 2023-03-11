using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;







namespace ADN102._09.NamespaceActivities_Pages_8_9_and_12
{
    class Tester
    {

        public static void Test_Page8(object o)
        {
            string success = "Success. You did it!";
            Type t = o.GetType();
            if ("Transportation.Vehicles.Auto" != t.FullName )
            {
                Console.WriteLine("The class you provided does not meet the following requirements:\nName: Auto\n in the Namespace Vehicles\n Vehicles in the Namespace Transportation");
                success = "Failure.";
            }
            else
            {
                Console.WriteLine("The class you provided is named Auto, and is in the proper Namespaces... Part 1 succeeded");
            }
           
            var pmake = t.GetProperty("make");
            if (pmake == null)
            {
                success = "Failure.";
                Console.WriteLine("I cannot find the property 'make' for your class");
            }
            var pmodel = t.GetProperty("model");
            if (pmodel == null)
            {
                success = "Failure.";
                Console.WriteLine("I cannot find the property 'model' for your class");
            }
            Console.WriteLine("Trying to Create a default Auto");
            var c = t.GetConstructor(new Type[0]);

            if (c == null)
            {
                success = "Failure.";
                Console.WriteLine("I cannot find a default constructor for your class");

            }
            else
            {
                var a1 = c.Invoke(new object[0]);
                

                try
                {

                    pmake?.SetValue(a1, "Chevy");
                    pmodel?.SetValue(a1, "Corvette");
                    if (pmake?.GetValue(a1)?.ToString() != "Chevy" || pmodel?.GetValue(a1)?.ToString() != "Corvette")
                    {
                        success = "Failure.";
                        Console.WriteLine("I can see that you created the class, but I cannot set and read the values of the two properties 'make' and 'model' to Chevy Corvette.");

                    }
                    else
                    {
                        Console.WriteLine("Success:  was able to create a default object, set it as a Chevy Corvette, and read the make and model");
                    }
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            
                
            }


            c = t.GetConstructor(new Type[] { typeof(string), typeof(string) });

            if (c == null)
            {
                success = "Failure.";
                Console.WriteLine("I cannot find a constructor taking two strings for your class");

            }
            else
            {
                Console.WriteLine("Trying to create an Auto as a Ford Mustang");
                var a2 = c.Invoke(new object[] { "Ford", "Mustang" });
                

                try
                {
                    if (pmake?.GetValue(a2)?.ToString() != "Ford" || pmodel?.GetValue(a2)?.ToString() != "Mustang")
                       
                        {
                            success = "Failure.";
                            Console.WriteLine("I can see that you created the class , but I cannot read the values of the two properties 'make' and 'model' as Ford Mustang.");

                        }
                    else
                    {
                        Console.WriteLine("Success:  was able to create an object as a Ford Mustang, and read the make and model");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

                
            }

           

            Console.WriteLine(success);
        }

        public static void Test_Page9()
        {

            MyNamespace.MyObjects.Widget w = new MyNamespace.MyObjects.Widget();
            Exercise.Test t = new Exercise.Test();
            Type tp = t.GetType();
            var m = tp.GetMethod("TestWidget");
            if (m == null)
            {
                Console.WriteLine("I could not find the TestWidget Method\n Failure...");
                return;
            }
            m.Invoke(t, new object[] { w });
            if (w.viewed == 1)
            {
                Console.WriteLine("Success. You did it!");
            }
            else
            {
                Console.WriteLine("Failure: I can see that you defined the test method correctly. However, the value of the widget's 'viewed' property should be 1 and it's not. Did you increment it in your 'TestWidget' method?");
            }
        }
    }
}

