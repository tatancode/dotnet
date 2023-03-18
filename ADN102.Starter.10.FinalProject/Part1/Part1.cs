using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part1
{   
    static class TaxCalculator
    {
        // Create a static dictionary field that holds a List of TaxRecords and is keyed by a string
        public static Dictionary<string, List<TaxRecord>> taxRecords = new Dictionary<string, List<TaxRecord>>();

        // create a static constructor that:
        static TaxCalculator()
        {
            // declare a streamreader to read a file
            System.IO.TextReader reader = System.IO.File.OpenText("taxtable.csv");
            string line;
            
            // enter a try/catch block for the entire static constructor to print out a message if an error occurs 
            while (!string.IsNullOrWhiteSpace(line = reader.ReadLine())) 
            {
                

                try
                {
                    List<TaxRecord> listTaxRecords = new List<TaxRecord>();
                    TaxRecord tr = new TaxRecord(line);
                    // 1. Find state code is in dictionary. TryFindValue -out par list
                    if (taxRecords.TryGetValue(tr.StateCode, out listTaxRecords))
                    {
                        //  - true : found list.Add new tax record to list.
                        listTaxRecords.Add(new TaxRecord(line));
                    }
                    //  - false: not found. create new empty list. Add tax record to new list. Add list to dictionary under state key. 
                    else
                    {
                        List<TaxRecord> newTaxRecordsList = new List<TaxRecord>();
                        newTaxRecordsList.Add(new TaxRecord(line));
                        taxRecords.Add(tr.StateCode,newTaxRecordsList);
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            reader.Close();
            // initialize the static dictionary to a newly create empty one
            // open the taxtable.csv file into the streamreader
            // loop over the lines from the streamreader 
            // read a line from the file
            // constuct a taxrecord from the (csv) line in the file
            // see if the state in the taxrecord is already in the dictionary
            //     if it is:  add the new tax record to the list of records in that state
            //     if it is not
            //            create a new list of taxrecords
            //            add the new taxrecord to the list
            //            add the list to the dictionary under the state for the taxrecord
            //provide a way to get out of the loop when you are done with the file....
            // catch any exceptions while processing each line in another try/catch block located INSIDE the loop
            //   this way if the line in the CSV file is incorrect, you will continue to process the next line
            // make sure the streamreader is disposed no matter what happens.
        }
        
        public static bool Verbose;
        
        // create a static method (ComputeTaxFor)  to return the computed tax given a state and income
        public static decimal ComputeTaxFor(string stCode, int income)//
        {
            //Creating a list
            List<TaxRecord> taxBrackets;
            //  Create a variable to hold the final computed tax.  set it to 0 
            decimal finalTax = 0;
            //  use the state as a key to find the list of taxrecords for that state
            //   throw an exception if the state is not found.
            if (!taxRecords.TryGetValue(stCode,out taxBrackets))
            {
                throw new Exception($"Did not find {stCode} in data base.");
            }
            //   otherwise use the list to compute the taxes
            else
            {
                //Looping goes here
                //  loop over the list of taxrecords for the state

                foreach (var item in taxBrackets)
                {
                    //     check to see if the income is within the tax bracket using the floor and ceiling properties in the taxrecord
                    //     if NOT:  (the income is greater than the ceiling)
                    //        compute the total tax for the bracket and add it to the running total of accumulated final taxes
                    //        the total tax for the bracket is the ceiling minus the floor times the tax rate for that bracket.  
                    //        all this information is located in the taxrecord
                    //        after adding the total tax for this bracket, continue to the next iteration of the loop
                    
                    if (income > item.Ceiling)
                    {
                        finalTax += (item.Ceiling - item.Floor) * item.taxRate;
                        continue;
                    }
                    //     IF The income is within the tax bracket (the income is higher than the floor and lower than the ceiling
                    //        compute the final tax by adding the tax for this bracket to the accumulated taxes
                    //        the tax for this bracket is the income minus the floor time the tax rate for this bracket
                    //        this number is the total final tax, and can be returned as the final answer
                    else if (income > item.Floor && income < item.Ceiling)
                    {
                        finalTax = (income - item.Floor) * item.taxRate;
                     }
                   
                }
                return finalTax;
            }
               // try to figure out how to implement the Verbose option AFTER you have everything else done.

        }
    }  // this is the end of the Tax Calculator

    class TaxRecord
    {
        // create a TaxRecord class representing a line from the file.  It shoudl have public properties of the correct type
        // for each of the columns in the file

        //  StateCode   (used as the key to the dictionary)
        public string StateCode { get; set; }
        //  State       (Full state name)
        public string State { get; set; }
        //  Floor       (lowest income for this tax bracket)
        public decimal Floor { get; set; }
        //  Ceiling     (highest income for this tax bracket )
        public decimal Ceiling { get; set; }
        //  Rate        (Rate at which income is taxed for this tax bracket)
        public decimal taxRate { get; set; }
        //  Create a ctor taking a single string (a csv) and use it to load the record
        //  Be sure to throw detailed exceptions when the data is invalid
        public TaxRecord(string csv)
        {
            string[] data = csv.Split(',');
            if (5 != data.Length)
            {
                throw new Exception($"CSV Entry'{csv}' does not hava exactly 5 parts (state code, state name, floor, ceiling, tax rate)");
            }
            StateCode = data[0];
            decimal temp;
            if (!decimal.TryParse(data[2], out temp))
            {
                throw new Exception($"CSV Entry{csv} part 3 is not a decimal");
            }
            Floor = temp;
            if (!decimal.TryParse(data[3], out temp))
            {
                throw new Exception($"CSV Entry{csv} part 4 is not a decimal");
            }
            Ceiling = temp;
            if (!decimal.TryParse(data[4], out temp))
            {
                throw new Exception($"CSV Entry{csv} part 5 is not a decimal");
            }
            taxRate = temp;
        }
            //  Create an override of ToString to print out the tax record info nicely
            public override string ToString()
        {
            return $"State Code: { StateCode}  State:{ State}  Floor: {Floor}  Ceiling: { Ceiling} Tax Rate: { taxRate}";
        }
    

    }  // this is the end of the TaxRecord

    class Program
    {
        public static void Main()
        {

            // create an infinite loop to:
            // prompt the user for a state and an income
            // validate the data
            // calculate the tax due and print out the total***
            while (true)
            {
                
                Console.WriteLine("Input State:");
                string state = Console.ReadLine().ToUpper();
                Console.WriteLine("Input Income:");
                string income = Console.ReadLine();
                int inc = int.Parse(income);
                if (string.IsNullOrWhiteSpace(state))
                {
                    Console.WriteLine($"Did not get a valid input. Instead got '{state}'");
                    continue;
                }
                if (!int.TryParse(income, out inc))
                {
                    Console.WriteLine($"Did not get a valid input. Instead got '{state}'");
                    continue;
                }
                else
                {
                    
                    Console.WriteLine(TaxCalculator.ComputeTaxFor(state, inc));
                    
                }

                }
                

                // after accomplishing this, you may want to also prompt for verbose mode or not in this loop
                // wrap everythign in a try/catch INSIDE the loop.  print out any exceptions that are unhandled
                //  something like this:


                //do
                //{
                //    try
                //    {
                //        put your logic here
                //    }
                //    catch (Exception ex)
                //    {
                //        Console.WriteLine(ex.Message);
                //    }
                //} while (true);


            }
    }

}
