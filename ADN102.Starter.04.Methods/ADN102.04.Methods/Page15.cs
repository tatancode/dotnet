using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Create a program called Counting which will accept a command line argument consisting of an integer.
//The program will start with the number 1 and count up to the number supplied using the following guidelines:
//Each line will be the current count duplicated the current number of times,
//with each duplicated number on a line separated by spaces.

//The implementation will have three methods, Main, MakeALine, and MakeAllLines.

//MakeALine will accept a formal parameter of type integer,
//    and will return a string representing the single line to be printed for that number, using a StringBuilder.

//MakeAllLines will accept a formal parameter of type integer,
//    and will return a string representing the entire set of lines.
//    It will invoke MakeALine in a loop to produce the return value.

//Main will accept an array of strings as a formal parameter
//and will return void (as is normal for the entry point).
//Main will check to ensure that only a single parameter is supplied,
//verify the parameter is a valid integer,
//invoke MakeAllLines, and finally print out the resulting string.

//Command line arguments can be provided at the command line itself,
//or can be provided as part of the property settings inside Visual Studio 2019.

// running with arguments of 4
//1
//2 2
//3 3 3
//4 4 4 4

// running with arguments of 7
//1
//2 2
//3 3 3
//4 4 4 4
//5 5 5 5 5
//6 6 6 6 6 6
//7 7 7 7 7 7 7

// running with arguments of 15
//1
//2 2
//3 3 3
//4 4 4 4
//5 5 5 5 5
//6 6 6 6 6 6
//7 7 7 7 7 7 7
//8 8 8 8 8 8 8 8
//9 9 9 9 9 9 9 9 9
//10 10 10 10 10 10 10 10 10 10
//11 11 11 11 11 11 11 11 11 11 11
//12 12 12 12 12 12 12 12 12 12 12 12
//13 13 13 13 13 13 13 13 13 13 13 13 13
//14 14 14 14 14 14 14 14 14 14 14 14 14 14
//15 15 15 15 15 15 15 15 15 15 15 15 15 15 15

// running wiht arguments of 'three'
//'three' was not recognized as a number



namespace Page15
{
    class Program
    {

        public static void Main(string[] args)
        {
            // check to make sure there is exactly 1 command line argument
            //     false:  print out message and exit
            //     true:  continue
           
            // check to make sure that the one argument is an integer number
            //     false: print out message and exit
            //     true:  continue (with the number in the integer variable 'theNumber'

            // invoke MakeAllLines(theNumber) and store the results into a variable
            // print out the results

            

        }

        static string MakeALine(int number)
        {
            // create an instance of a stringbuilder

            // start a loop counting number times
                // append the number into the stringbuilder
                // append a space into the stringbuilder
                // continue looping to the next number

            // convert the string builder to a string and return it.



            return "replace this with the stringbuilder results";
        }

        static string MakeAllLines(int number)
        {
            // create an instance of a stringbuilder
            // start a loop counting number times
            // append the result of calling MakeALine for this particular line into the string builder
            // append an 'newline' into the stringbuilder (call AppendLine on the stringbuilder)
            // continue looping to the next number

            // convert the string builder to a string and return it.

            return "replace this with the stringbuilder results";
        }

    }
}
