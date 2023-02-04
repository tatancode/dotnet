using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Given the Bird class below, construct the base class Animal from which it inherits.

//For the Animal class, you will need:
    //A default constructor.
    //A constructor that accepts values for its two string properties: name and birthMethod.
    //A public method named GiveBirth(no parameters) that returns the value of the birthMethod property (a string).
// You will need to uncomment lines 23-28 in order to do this activity 
namespace Page17
{
    public class Bird : Animal
    {
        bool flies;

        public Bird() : base()
        {
            this.flies = true;
        }
        //uncomment the following lines before you start this exercise
        public Bird(string name, bool flies)
            : base(name, "eggs")
        {
            this.flies = flies;
        }
    }
    public class Animal
    {
        public string Name;
        public string BirthMethod { get; set; }
        public Animal()
        {
            Name = "Default Name";
            
        }
        public Animal(string name, string birthMethod)
        {
            Name = name;
            BirthMethod = birthMethod;

        }

        public string GiveBirth()
        {
            return BirthMethod;
        }
    }
}
