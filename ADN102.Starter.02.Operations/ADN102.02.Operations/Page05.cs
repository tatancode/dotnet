using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Page5
{
    class Program
    {

        public static void Main()
        {
            Console.WriteLine("****Example 1*****");
            var a = 5;
            var b = 6;
            if (a == 6)
            {
                Console.WriteLine("A equals six!");
            }
            else if (b == 6)
            {
                Console.WriteLine("B equals six!");
            }
            else
            {
                Console.WriteLine("False");
            }

            Console.WriteLine("****Larger Example*****");

            // First the variable rating is declared and set to 7 (which is invalid).
            var rating = 7;

            // if the user rated the restaurant 5-stars, print "This food is the best! I could eat this every day."
            if (rating == 5)
            {
                Console.WriteLine("This food is the best! I could eat this every day.");
            }
            // if the user rated the restaurant 4-stars, print "Good meal."
            else if (rating == 4)
            {
                Console.WriteLine("Good meal.");
            }
            // if the user rated the restaurant 3-stars, print "It was OK."
            else if (rating == 3)
            {
                Console.WriteLine("It was OK.");
            }
            // if the user rated the restaurant 2-stars, print "I did not like this, but it's cheap."
            else if (rating == 2)
            {
                Console.WriteLine("I did not like this, but it's cheap.");
            }
            // if the user rated the restaurant 1-star,  print "I will never eat here again."
            else if (rating == 1)
            {
                Console.WriteLine("I will never eat here again.");
            }
            // Validation for number entered outside of rating.
            else
            {
                Console.WriteLine("Please enter a valid rating of 1-5.");
            }

            Console.WriteLine("****Order Matters (wrong)*****");

            int score = 95;
            string grade="oops I am less than 70";

            if (score > 70)
            {
                grade = "C";
            }
            else if (score > 80)
            {
                grade = "B";
            }
            else if (score > 90)
            {
                grade = "A";
            }
            Console.WriteLine(grade);

            Console.WriteLine("****Order Matters (almost right) for 95 *****");
            grade = "oops I am less than 70";

            if (score > 90)
            {
                grade = "A";
            }
            else if (score > 80)
            {
                grade = "B";
            }
            else if (score > 70)
            {
                grade = "C";
            }
            Console.WriteLine(grade);

            Console.WriteLine("****Order Matters (almost right) for 69 *****");
            grade = "oops I am less than 70";
            score = 69;

            if (score > 90)
            {
                grade = "A";
            }
            else if (score > 80)
            {
                grade = "B";
            }
            else if (score > 70)
            {
                grade = "C";
            }
            Console.WriteLine(grade);

            Console.WriteLine("****Order Matters (totally right (for scores less than 70) *****");
            grade = "oops I am less than 70";

            score = 69;
            if (score > 90)
            {
                grade = "A";
            }
            else if (score > 80)
            {
                grade = "B";
            }
            else if (score > 70)
            {
                grade = "C";
            }
            else
            {
                grade = "F";
            }
            Console.WriteLine(grade);
        }
    }
}
