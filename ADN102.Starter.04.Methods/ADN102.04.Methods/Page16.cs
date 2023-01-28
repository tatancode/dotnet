using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// carefully look at the PROPERTIES for the file "invoices.data" in the project
// you will notice the "Copy to output directory" is set to "Copy if Newer"
// this way any changes you make to the invoices.dat will be copied to the output directory
// and be reflected when you run the program

//Create an application for CSharp Technologies and name it ProcessInvoices.

//The Main() method will read a file (named invoices.dat) containing comma separated values (CSV)
//for a set of invoices(data format detailed later in this problem).
//For each invoice in the file, the program will calculate the late fee associated with that invoice.
//The effective date for the late fee calculation will be passed in as a command line argument.
//If the command line argument is left off, the current date will be used instead.


//Pass those values to a method called computeLateFees that accepts three parameters,
//the current date, the due date, and the invoice amount.
//The method will return the calculated late fee.
//The late fee is computed as follows:

//10 % of the total bill (not including late fees) per day for the first seven days.
//For each additional day over seven days, the cost is 1% of the total bill (not including late fees) for each additional day.

//The Main entry point will print out a message telling you what date it is using to calculate the fees,
//then it will open the file, read the data one line at a time,
//parse the data into variables which can be sent to the computeLateFees method,
//and will print out the invoice number, the invoice amount, the number of days late, and the late fee.
//Any line containing invalid data will cause a message to be displayed indicating why,
//that line will be skipped, and the processing will continue to the next line.

//The file will have the following information encoded as CSV:
//invoiceNumber, DueDate, InvoiceAmount

//here is a sample file:

//1, 1 / 1 / 2021, 1.11
//2, 2 / 2 / 2021, 2.22
//3, 3 / 3 / 2021, 3.33
//4, 4 / 4 / 2021, 4.44
//5, 5 / 5 / 2021, 5.55
//6, 6 / 6 / 2021, 6.66
//7, 7 / 7 / 2021, 7.77
//8, 8 / 8 / 2021, 8.88
//9, 9 / 9 / 2021, 9.99

// an invalid file to try as well

//1, 1 / 1 / 2021, 1.11
//2x, 2 / 2 / 2021, 2.22
//3, 3 / 3x / 2021, 3.33
//4, 4 / 4 / 2021, 4.4x4
//5, 5 / 5 / 2021, 5.55
//6, 6 / 6 / 2021
//7, 7 / 7 / 2021, 7.77
//8, 8 / 8 / 2021, 8.88
//9, 9 / 9 / 2021, 9.99

// a trial run
//The Date used for calculating late fees is 4/29/2021 12:00:00 AM
//Invoice: 1   Due: Jan 01 / 2021          Amount: 1.11 Late Fee: 2.01
//Invoice: 2   Due: Feb 02 / 2021          Amount: 2.22 Late Fee: 3.31
//Invoice: 3   Due: Mar 03 / 2021          Amount: 3.33 Late Fee: 4.00
//Invoice: 4   Due: Apr 04 / 2021          Amount: 4.44 Late Fee: 3.91
//Invoice: 5   Due: May 05 / 2021          Amount: 5.55 Late Fee: 0
//Invoice: 6   Due: Jun 06 / 2021          Amount: 6.66 Late Fee: 0
//Invoice: 7   Due: Jul 07 / 2021          Amount: 7.77 Late Fee: 0
//Invoice: 8   Due: Aug 08 / 2021          Amount: 8.88 Late Fee: 0
//Invoice: 9   Due: Sep 09 / 2021          Amount: 9.99 Late Fee: 0

// an invalid run using the invalid data 

//The Date used for calculating late fees is 4/29/2021 12:00:00 AM
//Expected element 0 in '2x, 2/2/2021, 2.22' to be an int
//Expected element 1 in '3, 3/3x/2021, 3.33' to be a datetime
//Expected element 2 in '4, 4/4/2021, 4.4x4' to be a decimal
//Expected 3 elements in '6, 6/6/2021' separated by ','
//Invoice: 1   Due: Jan 01 / 2021          Amount: 1.11 Late Fee: 2.01
//Invoice: 5   Due: May 05 / 2021          Amount: 5.55 Late Fee: 0
//Invoice: 7   Due: Jul 07 / 2021          Amount: 7.77 Late Fee: 0
//Invoice: 8   Due: Aug 08 / 2021          Amount: 8.88 Late Fee: 0
//Invoice: 9   Due: Sep 09 / 2021          Amount: 9.99 Late Fee: 0


namespace Page16
{
    class Program
    {
        // the implementation of Main is left up to YOU
        // the implementation of the invoice class is below, and is provided for you
        public static void Main(string[] args)
        {
            // create a default date to use if no command line args
            DateTime processFrom = DateTime.Now;
            // if the command line arguments are exactly 1
            // then use DataTime.TryParse to convert the argment to a date and place it into the processFrom variable

            // in all cases print out a message stating when the late fees are being calculated from


            // assume an invoice class exists and that it has a method to read a csv line and make an invoice from it
            // create a List of invoice variable to hold all the invoices

            // open the 'invoices.data' file and read each line into an array of invoices using a streamreader

                // create an infinite loop
                   // read a line from the file
                   // break out of the loop if blank line or end of file 
                   // enter into a try/catch block to catch errors
                       // create an invoice and read the csv into it
                       // add the invoice to the List of invoices
                   // catch any exceptions and print out a message
                   // continue to the next iteration of the loop
                // when breaking out of the loop
                // assume that there is a method in the invoice class to calculate the late fee
                // loop over all the invoices in the List
                   // print out the late fee by invoking the method in the class to calculate the late fee

            
        }
    }

    // this is a sample invoice class completely implemented for you


    class Invoice
    {
        // this class has three 'properties'   InvoiceNumber, DueDate and InvoiceAmount
        // these are the three items in the CSV file
        // Each line in the CSV File represents one of these invoice items
        public int InvoiceNumber { get; set; }
        public DateTime DueDate { get; set; }
        public decimal InvoiceAmount { get; set; }

        public override string ToString()
        {
            return $"Invoice: {InvoiceNumber,-3} Due:{DueDate,-20:MMM dd/yyyy} Amount: {InvoiceAmount}";
        }

        public static Invoice CreateInvoice(string csv)
        {
            // split the string into parts
            var items = csv.Split(',');
            // verify that there are 3 parts
            if (items.Length != 3)
            {
                throw new Exception($"Expected 3 elements in '{csv}' separated by ','");
            }
            // make three variables to hold the values from the string
            int tempinvoicenumber;
            DateTime tempdate;
            decimal tempamount;

            // try to read the zeroth item into the invoicenumber using TryParse
            if (!int.TryParse(items[0], out tempinvoicenumber))
            {
                throw new Exception($"Expected element 0 in '{csv}' to be an int");
            }
            // try to read the next item into the date using TryParse
            if (!DateTime.TryParse(items[1], out tempdate))
            {
                throw new Exception($"Expected element 1 in '{csv}' to be a datetime");
            }
            // try to read the last number into the invoiceamount using TryParse
            if (!decimal.TryParse(items[2], out tempamount))
            {
                throw new Exception($"Expected element 2 in '{csv}' to be a decimal");
            }
            // this is the way to create a new invoice (discussed in the next Lesson)
            return new Invoice()
            {
                InvoiceNumber = tempinvoicenumber,
                DueDate = tempdate,
                InvoiceAmount = tempamount
            };
        }


        // this method computes the actual late fee
        public decimal ComputeLateFee(DateTime ComputeFrom)
        {
            decimal rv = 0;
            int dayslate = (ComputeFrom - DueDate).Days;
            // subtracting two DateTime objects gives you an integer count of the number of days between the two dates.
            switch (dayslate)
            {
                // this is a special way of constructing a case statement in a switch
                // using a formula instead of a hardcoded value.  notice the when clause catches all
                // dayslate over 7
                // the variable i will contain the actual number of days 
                case int i when i > 7:
                    // the late fee is 10% per day for the first 7 days and then 1% per day over 7
                    // or .70 for seven days and then .01 for the days over 7 (subtract the first seven days)
                    // the M means the type decimal
                    return (.7M * InvoiceAmount) + .01M * InvoiceAmount * (dayslate - 7);

                case int i when i > 0:
                    // this is the case where the days late is 1- 7  (it is not over 7)
                    // 10% per day
                    return .1M * InvoiceAmount * dayslate;


                default:
                    // otherwise the dayslate is negative, and it is not late yet.
                    // so no late fee
                    return 0;

            }
            // this is unreachable code since all cases of the switch return.
            return rv;
        }
    }
}
