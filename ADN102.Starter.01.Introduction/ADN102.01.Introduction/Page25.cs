using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Page25
{ 
    class Program
    {
        public static string StudentMain(int age)
        {

            // test age and return the correct movie title using a series of if statements
            string movie = "";
            // The Terminator is Rated R. 17 or older.
            if (age >= 17)
            {
                movie ="The Terminator";
            }
            // Jurassic Park is Rated PG - 13. 13 or older.
            else if(age >= 13)
            {
                movie = "Jurassic Park";
            }
            // Home Alone is Rated PG. 7 or older.
            else if (age >= 7)
            {
                movie = "Home Alone";
            }
            // Cinderella is rated G for all audiences.
            else if (age <= 7)
            {
                movie = "Cinderella";
            }

            return movie;



        }
    }
}
