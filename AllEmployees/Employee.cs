//
// FILE: Employee.cs
// PROJECT: Employee Management System Project
// PROGRAMMERS: Jay Moorhouse, Jordan Poirier, Thom Taylor, Rachel Park
// DATE: 11/13/2014
// DESCRIPTION: Contains the class definition for the Employee parent class.
//              Included are the variables, contructors, and methods.
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
    ///  The Employee Class, to be the parent of several sub-types of employees
    /// </summary>
    public class Employee
    {
        protected string firstName; /// Employee First Name
        protected string lastName; /// Employee Last Name
        protected string socialInsuranceNumber; /// Employee Social Insurance Number
        protected DateTime dateOfBirth; /// Employee Date of Birth
        protected String type;

        private Validation val;
        /// <summary>
        /// The Employee() method is a Constructor for the Employee Class.
        /// This version of the constructor initializes all values to default (blank/0).
        /// </summary>
        public Employee()
        {
            firstName = "";
            lastName = "";
            socialInsuranceNumber = "";
            dateOfBirth = new DateTime();
            type = "";
            val = new Validation();
        }

        /// <summary>
        /// Overloaded Employee constructor.
        /// This version of the constructor sets the first and last name variables
        /// to the input parameter values, and sets the other fields to default (blank/0).
        /// </summary>
        /// <param name="first">The string to initialize the firstName variable to</param>
        /// <param name="last">The string to initialize the lastName variable to</param>
        public Employee(string first, string last)
        {
            firstName = first;
            lastName = last;
            val = new Validation();
        }

        /// <summary>
        /// Overloaded Employee constructor.
        /// This version of the constructor sets all variables to the input parameter values.
        /// </summary>
        /// <param name="first">The string to initialize the firstName variable to</param>
        /// <param name="last">The string to initialize the lastName variable to</param>
        /// <param name="SIN">The string to set initialize socialInsuranceNumber variable to</param>
        /// <param name="DOB">The string to initialize the dateOfBirth variable to</param>
        public Employee(string firstName, string lastName, string socialInsuranceNumber, DateTime dateOfBirth, String type)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.socialInsuranceNumber = socialInsuranceNumber;
            this.dateOfBirth = dateOfBirth;
            this.type = type;
            val = new Validation();
        }

        /// <summary>
        /// The setter for firstName
        /// </summary>
        /// <param name="fName">The string to set the firstName variable to</param>
        /// <returns>A boolean indicating whether the setting operation was successful</returns>
        public bool SetFirstName(string fName)
        {
            bool retV = false;
            if(val.ValidateName(fName) == true)
            {
                firstName = fName;
                retV = true;
            }
            return retV;
        }

        /// <summary>
        /// The setter for lastName
        /// </summary>
        /// <param name="lName">The string to set the lastName variable to</param>
        /// <returns>A boolean indicating whether the setting operation was successful</returns>
        public bool SetLastName(string lName)
        {
            bool retV = false;
            if (val.ValidateName(lName) == true)
            {
                lastName = lName;
                retV = true;
            }
            return retV;
        }

        /// <summary>
        /// The setter for socialInsuranceNumber
        /// </summary>
        /// <param name="SIN">The string to set the socialInsuranceNumber to</param>
        /// <returns>A boolean indicating whether the setting operation was successful</returns>
        public bool SetSIN(string SIN)
        {
            bool retV = false;
            if (val.ValidateSIN(SIN) == true)
            {
                socialInsuranceNumber = SIN;
                retV = true;
            }
            return retV;
        }

        public bool SetType(string type)
        {
            this.type = type;
            return true;
        }

        /// <summary>
        /// The setter for dateOfbirth
        /// </summary>
        /// <param name="dob">The string to set the dateOfBirth to</param>
        /// <returns>A boolean indicating whether the setting operation was successful</returns>
        public bool SetDOB(DateTime dob)
        {
            bool retV = false;
            if (val.ValidateDate(dob.ToString()) == true)
            {
                dateOfBirth = dob;
                retV = true;
            }
            return retV;
        }


        /// <summary>
        /// Method is called upon to output (to the screen) all attribute values for the class.
        /// </summary>
        public virtual void Details()
        {
            Console.WriteLine("First Name: {0}", this.firstName);
            Console.WriteLine("Last Name : {0}", this.lastName);
        }

        /// <summary>
        /// Method ensures that all current attribute settings are in fact valid for this employee type
        /// **logs the employee’s name (lastName, firstName) and socialInsuranceNumber values as well as whether the object is valid or not**
        /// </summary>
        /// <returns></returns>
        public bool Validate()
        {
            bool isValid = false;

            return isValid;
        }
    }
}
