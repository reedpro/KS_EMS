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
        private DateTime? contractStartDate;
        private DateTime? contractEndDate;
        private String fixedContractAmt;

        /// <summary>
        /// The ContractEmployee() method is a Constructor for the ContractEmployee Class.
        /// This version of the constructor initializes all values to default (blank/0).
        /// </summary>
        public ContractEmployee() : base()
        {
            contractStartDate = null;
            contractEndDate = null;
            fixedContractAmt = "0";
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
            DateTime startDate, DateTime endDate, string rate)
            : base(first, last, SIN, DOB)
        {
            contractStartDate = startDate;
            contractEndDate = endDate;
            fixedContractAmt = rate;
        }

        public DateTime? GetContractStartDate()
        {
            return contractStartDate;
        }
        public DateTime? GetContractEndDate()
        {
            return contractEndDate;
        }
        public String GetFixedContractAmt()
        {
            return fixedContractAmt;
        }

        public bool SetContractStartDate(DateTime? cStartDate)
        {
            bool retV = false;

            return retV;
        }


        public bool SetContractEndDate(DateTime cEndDate)
        {
            bool retV = false;

            return retV;
        }


        public bool SetFixedContractAmt(string fAmt)
        {
            bool retV = false;
            return retV;
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
                contractEndDate + "\n" +
                fixedContractAmt);
        }
    }
}
