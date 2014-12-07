//
// FILE: FulltimeEmployees.cs
// PROJECT: Employee Management System Project
// PROGRAMMERS: Jay Moorhouse, Jordan Poirier, Thom Taylor, Rachel Park
// DATE: 11/13/2014
// DESCRIPTION: Contains the class definition for the FulltimeEmployees child class.
//              Included are the variables, contructors, and methods.
//              Inherited from Employee.cs
//  
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Supporting;

namespace AllEmployees
{
    /// <summary>
    /// The FulltimeEmployee Class, a child class of Employee
    /// </summary>
    public class FulltimeEmployee : Employee
    {
        private DateTime? dateOfHire;
        private DateTime? dateOfTermination;
        private Double salary;

        /// <summary>
        /// The FulltimeEmployee() method is a Constructor for the FulltimeEmployee Class.
        /// This version of the constructor initializes all values to default (blank/0).
        /// </summary>
        public FulltimeEmployee() : base()
        {
            dateOfHire = null;
            dateOfTermination = null;
            salary = 0.00;

            SetType("FT");
        }

        /// <summary>
        /// Overloaded  FulltimeEmployee constructor.
        /// This version of the constructor sets all variables to parameter values
        /// </summary>
        /// <param name="first">The string to initialize the firstName variable to</param>
        /// <param name="last">The string to initialize the lastName variable to</param>
        /// <param name="SIN">The string to initialize the socialInsuranceNumber variable to</param>
        /// <param name="DOB">The date to set the dateOfBirth variable to</param>
        /// <param name="hDate">The date to set the dateOfHire variable to</param>
        /// <param name="tDate">The date to set the dateOfTermination variable to</param>
        /// <param name="inSalary">The string to set the Salary variable to</param>
        public FulltimeEmployee(String first, String last, String SIN, DateTime? DOB, DateTime? hDate,
            DateTime? tDate, Double inSalary)
            : base(first, last, SIN, DOB)
        {
            SetDateOfHire(hDate);
            SetDateOfTermination(tDate);
            SetSalary(inSalary);

            SetType("FT");
        }

        public DateTime? GetDateOfHire()
        {
            return dateOfHire;
        }
        public DateTime? GetDateOfTermination()
        {
            return dateOfTermination;
        }

        public Double GetSalary()
        {
            return salary;
        }

        /// <summary>
        /// The setter for dateOfHire
        /// </summary>
        /// <param name="hDate">The date to set the dateOfHire variable to</param>
        /// <returns>A boolean indicating whether the setting operation was successful</returns>
        public bool SetDateOfHire(DateTime? hDate)
        {
            bool retV = false;
            if (hDate == null)
            {
                log.writeLog(
                    produceLogString("SET",
                                    (dateOfHire.HasValue ? dateOfHire.Value.ToString("yyyy-MM-dd") : "N/A"),
                                    "N/A",
                                    "SUCCESS"));
                retV = true;
            }
            else
            {
                DateTime newDOH = (DateTime)hDate;

                //if(CheckDateRange(dateOfBirth, dateOfTermination, newDOH) == true)
                //{
                //    log.writeLog(produceLogString("SET", dateOfHire.ToString("yyyy-MM-dd"), hDate.ToString("yyyy-MM-dd"), "SUCCESS"));
                //    dateOfHire = hDate;
                //    retV = true;
                //}
                //else
                //{
                //    log.writeLog(produceLogString("SET", dateOfHire.ToString("yyyy-MM-dd"), hDate.ToString("yyyy-MM-dd"), "FAIL")
                //       + "\nDetail: Should come after Birthday and before Termination Date");
                //}
            }
            return retV;
        }

        /// <summary>
        /// The setter for dateOfTermination
        /// </summary>
        /// <param name="tDate">The date to set the dateOfTermination variable to</param>
        /// <returns>A boolean indicating whether the setting operation was successful</returns>
        public bool SetDateOfTermination(DateTime tDate)
        {
            bool retV = false;
            //if (CheckDateRange(dateOfHire, DateTime.MaxValue, dateOfTermination) == true)
            //{
            //    log.writeLog(produceLogString("SET", dateOfHire.ToString("yyyy-MM-dd"), tDate.ToString("yyyy-MM-dd"), "SUCCESS"));
            //    dateOfHire = tDate;
            //    retV = true;
            //}
            //else
            //{
            //    log.writeLog(produceLogString("SET", dateOfHire.ToString("yyyy-MM-dd"), tDate.ToString("yyyy-MM-dd"), "FAIL")
            //        + "\nDetail: Should come after Hiring date and before \"9999-12-31\"");
            //}
            return retV;
        }

        public bool CheckSalary(Double sal)
        {
            return sal > 0;
        }

        /// <summary>
        /// The setter for salary
        /// </summary>
        /// <param name="inSalary">The string to set the salary variable to</param>
        /// <returns>A boolean indicating whether the setting operation was successful</returns>
        public bool SetSalary(Double inSalary)
        {
            bool retV = false;
            if(CheckSalary(inSalary) == true)
            {
                log.writeLog(produceLogString("SET", salary.ToString("0.00"), inSalary.ToString("0.00"), "SUCCESS"));
                salary = inSalary;
                retV = true;
            }
            else
            {
                log.writeLog(produceLogString("SET", salary.ToString("0.00"), inSalary.ToString("0.00"), "FAIL")
                    + "\nDetail: Cannot be lower than zero");
            }
            return retV;
        }

        private bool validateDOH()
        {
            bool retV = false;

            return retV;
        }
        private bool validateDOT()
        {
            bool retV = false;

            return retV;
        }
        private bool validateSalary()
        {
            bool retV = false;

            return retV;
        }

        public bool Validate()
        {
            return base.Validate() && validateDOH() && validateDOT() && validateSalary();
        }

        protected override String ConsoleDetails()
        {
            String output ="";
            output += "\tDate of Hire:\t\t" + (dateOfHire.HasValue ? dateOfHire.Value.ToString("yyyy-MM-dd") : "N/A");
            output += "\tDate of Termination:\t" + (dateOfHire.HasValue ? dateOfHire.Value.ToString("yyyy-MM-dd") : "N/A");
            output += "\tSalary:\t\t\t" + salary.ToString("0.00");
            return output;
        }

        /// <summary>
        /// Method is called upon to output (to the screen) all attribute values for the class.
        /// </summary>
        public override void Details()
        {
            String consoleOutput = base.ConsoleDetails() + this.ConsoleDetails();
            Console.WriteLine(consoleOutput);
            log.writeLog(produceLogString("DETAILS", "", "", "")  + "\nInput: \n" + consoleOutput);
        }
    }
}
