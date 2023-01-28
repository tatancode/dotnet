using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Page24
{
    public class Person
    {
        protected string firstName;
        protected string lastName;

        // TODO: Accessors
        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                firstName = value;
            }
        }
        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                lastName = value;
            }
        }
        public string FullName
        {
            get
            {
                return $"{firstName}" + " " + $"{lastName}";
            }
        }








        public Person()
        {
            this.firstName = "";
            this.lastName = "";
        }
        public Person(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }
    }
}
