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
        private DateTime dateOfHire;
        private DateTime dateOfTermination;
        private String salary;

        /// <summary>
        /// The FulltimeEmployee() method is a Constructor for the FulltimeEmployee Class.
        /// This version of the constructor initializes all values to default (blank/0).
        /// </summary>
        public FulltimeEmployee() : base()
        {
            dateOfHire = new DateTime(0);
            dateOfTermination = new DateTime(0);
            salary = "0";

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
        public FulltimeEmployee(String first, String last, String SIN, DateTime DOB, DateTime hDate, 
            DateTime tDate, String inSalary) : base(first, last, SIN, DOB)
        {
            SetDateOfHire(hDate);
            SetDateOfTermination(tDate);
            SetSalary(inSalary);

            SetType("FT");
        }

        public DateTime GetDateOfHire()
        {
            return dateOfHire;
        }
        public DateTime GetDateOfTermination()
        {
            return dateOfTermination;
        }

        public String GetSalary()
        {
            return salary;
        }

        /// <summary>
        /// The setter for dateOfHire
        /// </summary>
        /// <param name="hDate">The date to set the dateOfHire variable to</param>
        /// <returns>A boolean indicating whether the setting operation was successful</returns>
        public bool SetDateOfHire(DateTime hDate)
        {
            bool retV = false;
            if(CheckDateRange(dateOfBirth, dateOfTermination, hDate) == true)
            {
                //log.writeLog(produceLogString("SET", hDate.ToString("yyyy-MM-dd"), 
                //dateOfHire = hDate;
            }
            else
            {

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
            dateOfTermination = tDate;
            if (dateOfTermination == tDate)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// The setter for salary
        /// </summary>
        /// <param name="inSalary">The string to set the salary variable to</param>
        /// <returns>A boolean indicating whether the setting operation was successful</returns>
        public bool SetSalary(String inSalary)
        {
            salary = inSalary;
            if (salary == inSalary)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        /// <summary>
        /// Method is called upon to output (to the screen) all attribute values for the class.
        /// </summary>
        public void Details()
        {
            Console.Write(firstName + "\n" +
                lastName + "\n" +
                socialInsuranceNumber + "\n" +
                dateOfBirth + "\n" +
                dateOfHire + "\n" +
                dateOfTermination + "\n" +
                salary);
        }
    }
}
