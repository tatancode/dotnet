using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Page6
{
    class Program
    {

        public static void Main()
        {
            Console.WriteLine("**** && ******");
            var isHungry = true;
            var isRestaurantOpen = true;

            if (isHungry && isRestaurantOpen)
            {
                Console.WriteLine($"True: Go to the restaurant! Hungry: {isHungry} && Open:{isRestaurantOpen}");
            }
            else
            {
                Console.WriteLine($"False: Don't go to the restaurant. Hungry: {isHungry} && Open:{isRestaurantOpen}");
            }

            Console.WriteLine("**** || ******");
            var isSleepy = false;
            var isLibraryClosed = false;

            if (isSleepy || isLibraryClosed)
            {
                Console.WriteLine($"True: You should leave now. Sleepy: {isSleepy} || Closed:{isLibraryClosed}");
            }
            else
            {
                Console.WriteLine($"False: Keep on studying! Sleepy: {isSleepy} && Closed:{isLibraryClosed}");
            }

            Console.WriteLine("**** ! ******");
            var isDaytime = true;
            isHungry = false;

            if (!(isDaytime && isHungry))
            {
                Console.WriteLine($"True: Don't eat. Daytime:{isDaytime} Hungry: {isHungry} !(Daytime && Hungry): {!(isDaytime && isHungry)}");
            }
            else
            {
                Console.WriteLine($"False: Time to eat! Daytime:{isDaytime} Hungry: {isHungry} !(Daytime && Hungry): {!(isDaytime && isHungry)}");
            }

            Console.WriteLine("**** (or)|| is like (addition) and (and)&& is like (multiply) in precedence ******");
            isSleepy = true;
            isLibraryClosed = false;
            var isBatteryDead = false;

            if (isBatteryDead || isSleepy && isLibraryClosed)
            {
                Console.WriteLine($"True: You should leave now. BatteryDead: {isBatteryDead} || Sleepy: {isSleepy} && Closed: {isLibraryClosed}: sleepy && closed evaluated first");
            }
            else
            {
                Console.WriteLine($"False: Keep on studying! BatteryDead: {isBatteryDead} || Sleepy: {isSleepy} && Closed: {isLibraryClosed}: sleepy && closed evaluated first");
            }

            Console.WriteLine("**** a < b [a less than b] ******");
            var a = 2;
            var b = 4;

            if (a < b)
            {
                Console.WriteLine($"a {a} is less than b {b}");
            }
            else
            {
                Console.WriteLine($"a {a} is not less than b {b}");
            }

            Console.WriteLine("**** a <= b [a less than or equal to b] ******");
            a = 2;
            b = 4;

            if (a < b)
            {
                Console.WriteLine($"a {a} is less than b {b}");
            }
            else if (a <= b)
            {
                Console.WriteLine($"a {a} is the same as b {b}");
            }
            else
            {
                Console.WriteLine($"a { a} is not less than b { b}");

            }

            Console.WriteLine("**** a >  b [a greater than b] ******");
            Console.WriteLine("**** a >=  b [a greater than or equal to b] ******");
            var userAge = 22;

            if (userAge < 18)
            {
                Console.WriteLine($"Sorry, you ({userAge}) are too young (< 18) to purchase tickets for this movie.");
            }
            else if (userAge >= 18)
            {
                Console.WriteLine($"You are {userAge}. Here are your tickets. Enjoy the movie!");
            }

        }
    }
}
