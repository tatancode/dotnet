using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Page8
{
    public class StudentInput
    {
        public bool studentCanWatch(int age, bool withParent)
        {
            bool canWatch = false;
            // canWatch is currently initialized to false
            //set the value of canWatch to true or false depending on the values of age and withParent.

            //canWatch should be set to true if:

                 //age is greater than or equal to 18 - or -
                 //age is greater than or equal to 13 - and - withParent is true
            
            //Otherwise, canWatch should be false.


            //canWatch = write an expression here
            if(age >= 18 || age >= 13 && withParent == true)
            {
                canWatch = true;
            }
            else
            {
                canWatch = false;
            }
            return canWatch;
        }
    }
}
