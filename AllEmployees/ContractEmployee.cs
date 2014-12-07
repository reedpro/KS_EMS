//
// FILE: ContractEmployee.cs
// PROJECT: Employee Management System Project
// PROGRAMMERS: Jay Moorhouse, Jordan Poirier, Thom Taylor, Rachel Park
// DATE: 11/13/2014
// DESCRIPTION: Contains the class definition for the ContractEmployee child class.
//              Included are the variables, contructors, and methods.
//              Inherited from Employee.cs
//  
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllEmployees
{
    /// <summary>
    /// The ContractEmployee Class, a child class of Employee
    /// </summary>
    public sealed class ContractEmployee : Employee
    {
        public DateTime? contractStartDate { get; private set; }
        public DateTime? dateOfTermination { get; private set; }
        public string hourlyRate { get; private set; }

        /// <summary>
        /// The ContractEmployee() method is a Constructor for the ContractEmployee Class.
        /// This version of the constructor initializes all values to default (blank/0).
        /// </summary>
        public ContractEmployee()
        {
            SetFirstName("");
            SetLastName("");
            SetSIN("");
            SetDOB(new DateTime());
            contractStartDate = null;
            dateOfTermination = null;
            hourlyRate = "0";
        }

        /// <summary>
        /// The ContractEmployee() method is a Constructor for the ContractEmployee Class.
        /// This version of the constructor initializes all values to input parameter values.
        /// </summary>
        /// <param name="first">The string to initialize the firstName variable to</param>
        /// <param name="last">The string to initialize the lastName variable to</param>
        /// <param name="SIN">The string to initialize the socialInsuranceNumber variable to</param>
        /// <param name="DOB">The date to set the dateOfBirth variable to</param>
        /// <param name="startDate">The date to set the contractStartDate variable to</param>
        /// <param name="terminationDate">The date to set the dateOfTermination variable to</param>
        /// <param name="rate">The value to set the hourlyRate variable to</param>
        public ContractEmployee(string first, string last, string SIN, DateTime DOB,
            DateTime startDate, DateTime terminationDate, string rate)
        {
            SetFirstName(first);
            SetLastName(last);
            SetSIN(SIN);
            SetDOB(DOB);
            contractStartDate = startDate;
            dateOfTermination = terminationDate;
            hourlyRate = rate;
        }

        /// <summary>
        /// The setter for the contractStartDate variable
        /// </summary>
        /// <param name="date">The date to set the contractStartDate variable to</param>
        /// <returns>A boolean indicating whether the setting operation was successful</returns>
        public bool SetContractStartDate(DateTime date)
        {
            contractStartDate = date;
            if (contractStartDate == date)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// The setter for the dateOfTermination variable
        /// </summary>
        /// <param name="date">The date to set the dateOfTermination variable to</param>
        /// <returns>A boolean indicating whether the setting operation was successful</returns>
        public bool SetDateOfTermination(DateTime date)
        {
            dateOfTermination = date;
            if (dateOfTermination == date)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// The setter for the hourlyRate variable
        /// </summary>
        /// <param name="rate">The value to set the hourlyRate variable to</param>
        /// <returns>A boolean indicating whether the setting operation was successful</returns>
        public bool SetHourlyRate(string rate)
        {
            hourlyRate = rate;
            if (hourlyRate == rate)
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
        public override void Details()
        {
            Console.Write(firstName + "\n" +
                lastName + "\n" +
                socialInsuranceNumber + "\n" +
                dateOfBirth + "\n" +
                contractStartDate + "\n" +
                dateOfTermination + "\n" +
                hourlyRate);
        }
    }
}
