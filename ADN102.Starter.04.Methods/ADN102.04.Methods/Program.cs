using System;

namespace ADN102._04.Methods
{
    class Program
    {

        // Project property settings were modified to set Program.Main as the startup object AND
        // Project Application arguments settings were modified (on the debug tab of project properties) 
        // to make the command line argument the number 15 for running Page15

        // if running Page16, the command line arguments are manually set back to an empty array, no matter what

        static void Main(string[] args)
        {
            // Page02.Program.Main();

            //Page04.Program.Main1();
            //Page04.Program.Main2();


            // Page05.Program.Main();

            // Page06.Program.Main();

            // Page07.Program.Main();



            // simulate args to main1
            //string[] simulatedargs = { "file1.txt", "filetwo.222", "data.data", "lastofthefiles.txt" };
            // Page08.Program.Main1(simulatedargs);


            // use the actual args to main1
            // Page08.Program.Main1(args);



            //Page08.Program.Main2();

            Testing.Test_Page9();

            //Page10.Program.Main();

            //args = new string[] { "three" };
            //Page15.Program.Main(args);

            //string[] page16args = new string[] { "4/29/2021" } ;
            //Page16.Program.Main(page16args);
        }

        // for Page15.  Try commenting out line 51 and un-commenting line 52 to see the difference it makes
        // this technique can be used to line numbers up better especially when sometimes they are 1 digit and 
        // other times they are 2 or 3 digits.
    }
}
