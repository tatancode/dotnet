using System;
//using TaxCalculator;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part2
{

    
    class EmployeeRecord
    {
        // create an employee Record with public properties
        //    ID                        a number to identify an employee
        public decimal ID { get; set; }
        //    Name                      the employee name
        public string Name { get; set; }
        //    StateCode                 the state collecting taxes for this employee
        public string StateCode { get; set; }
        //    HoursWorkedInTheYear      the total number of hours worked in the entire year (including fractions of an hour)
        public decimal HoursWorkedInTheYear { get; set; }
        //    HourlyRate                the rate the employee is paid for each hour worked
        public decimal HourlyRate { get; set; }
        //                                  assume no changes to the rate throughout the year.

        //    provide a constructor that takes a csv and initializes the employeerecord
        //       do all error checking and throw appropriate exceptions
        public EmployeeRecord(string csv)
        {
            string[] data = csv.Split(',');
            if (5 != data.Length)
            {
                throw new Exception($"CSV Entry'{csv}' does not hava exactly 5 parts (state code, state name, floor, ceiling, tax rate)");
            }
            ID = decimal.Parse(data[0]);
            Name = data[1];
            decimal temp;
            if (!decimal.TryParse(data[2], out temp))
            {
                throw new Exception($"CSV Entry{csv} part 3 is not a valid number");
            }
            StateCode = data[2];
            if (!decimal.TryParse(data[3], out temp))
            {
                throw new Exception($"CSV Entry{csv} part 4 is not a decimal");
            }
            HoursWorkedInTheYear = decimal.Parse(data[4]);
            if (!decimal.TryParse(data[4], out temp))
            {
                throw new Exception($"CSV Entry{csv} part 5 is not a decimal");
            }
            HourlyRate = decimal.Parse(data[4]);
        }

        //    provide an additional READ ONLY property called  YearlyPay that will compute the total income for the employee
        //        by multiplying their hours worked by their hourly rate
        public decimal YearlyPay { get { return (HoursWorkedInTheYear * HourlyRate); } }

        //    provide an additional READONLY property that will compute the total tax due by:
        //        calling into the taxcalculator providing the statecode and the yearly income computed in the YearlyPay property
     //   public decimal TaxDue { get { return (TaxCalculator.ComputeTaxFor(StateCode,YearlyPay)); } }
        //    provide an override of toString to output the record : including the YearlyPay and the TaxDue
    }

    static class EmployeesList
    {

        // create an EmployeeList class that will read all the employees form the Employees.csv file
        // the logic is similar to the way the taxcalculator read its taxrecords
        
        // Create a List of employee records.  The employees are arranged into a LIST not a DICTIONARY
        //   because we are not accessing the employees by state,  we are accessing the employees sequentially as a list
        //public static List<EmployeeRecord> employeeList = new List<EmployeeRecord>();
        // create a static constructor to load the list from the file
        //   be sure to include try/catch to display messages
        static EmployeesList()
        {
            System.IO.TextReader reader = System.IO.File.OpenText("employees.csv");
            string line;
            while (!string.IsNullOrWhiteSpace(line= reader.ReadLine()))
            {
                try
                {
                    List<EmployeeRecord> employeeList = new();
                    EmployeeRecord er = new EmployeeRecord(line);
                    if (employeeList[0] == null)
                    {
                        employeeList.Add(new EmployeeRecord(line));
                    }
                    else
                    {
                        List<EmployeeRecord> newEmployeeList = new();
                        newEmployeeList.Add(new EmployeeRecord(line));
                    }
                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                }
            }
        }
    }

    class Program
    {

        // loop over all the employees in the EmployeeList and print them
        // If the ToString() in the employee record is correct, all the data will print out.

        public static void Main()
        {
            List<EmployeeRecord> employeeList = new();
            try
            {

                // write your logic here
                foreach (var item in employeeList)
                {
                    
                    //if (employeeList[item] != null)
                    //{
                    //    Console.WriteLine($"{item} + {item.TaxDue} + {item.YearlyPay}");
                    //}
                }
            }



            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
