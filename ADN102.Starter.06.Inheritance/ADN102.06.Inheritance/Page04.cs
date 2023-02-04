using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Create a Vehicle class to serve as a parent.It will have an integer field called called "PassengerCapacity".

//Create a Bicycle class to serve as a child.It will add an integer field called "NumberofSpeeds".

//Create a MotorizedVehicle class derived from Vehicle.It will add an integer field called "FuelCapacity".

//Create a MotorCycle class derived from MotorizedVehicle.It will add a string field called "MotorcycleType".
//See the article: https://www.motorcyclelegalfoundation.com/types-of-motorcycles/ for some types.

//Create an Auto class derived from MotorizedVehicle.It will add a string called "Make" and another string called "Model"

//use the Main method in the StudentProgram class to validate your syntax.
// everything in Main is currenlty commented out.  Uncomment Main to see if it will compile

//use the dot operator on the various variables to see the fields*

//if you can't see the fields, make sure they are public

//if you still can't see them, make sure you are using inheritance

//if you still can't see them, ask for help!

namespace Page4
{
    using System;

    public class Vehicle
    {
        public int PassengerCapacity;
    }

    public class Bicycle :Vehicle
    {
        public int NumberofSpeeds;
    }

    public class MotorizedVehicle :Vehicle
    {
        public int FuelCapacity;
    }

    public class MotorCycle :MotorizedVehicle
    {
        public string Cruiser;
    }

    public class Auto :MotorizedVehicle
    {
        public string Make;
        public string Model;
    }

    public class StudentProgram
    {
        public static void Main()
        {
            Vehicle v = new Vehicle();
            Bicycle b = new Bicycle();
            MotorizedVehicle mv = new MotorizedVehicle();
            MotorCycle m = new MotorCycle();
            Auto a = new Auto();

            // try to attach a parent to a child
            v = a;    // auto is supposed to be derived from vehicle
            mv = a;   // auto is supposed to be derived from motorized vehicle
            mv = m;   // motorcycle is supposed to be derived from motorized vehicle
            v = b;    // bicycle is supposed to be derived from vehicle
                      // b = m;    // supposed to fail.  cannot connect siblings like bicycle and motorcycle.  will need to comment this line out

            v = a;
            mv = a;
            a.FuelCapacity = 20;
            a.Make = "Chevrolet";
            a.Model = "Corvette";
            a.PassengerCapacity = 2;

            Console.WriteLine(a.Model);              // can see all fields
            Console.WriteLine(v.PassengerCapacity);  // cannot see the make and model or fuel cap
            Console.WriteLine(mv.FuelCapacity);      // cannot see make and model
            

            Console.WriteLine("Success");
        
        }
    }
}
