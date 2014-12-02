//
// FILE: SeasonalEmployee.cs
// PROJECT: Employee Management System Project
// PROGRAMMERS: Jay Moorhouse, Jordan Poirier, Thom Taylor, Rachel Park
// DATE: 11/13/2014
// DESCRIPTION: Contains the class definition for the SeasonalEmployee child class.
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
    /// The SeasonalEmployee Class, a child class of Employee
    /// </summary>
    public class SeasonalEmployee : Employee
    {
        string season;
        string piecePay;

        /// <summary>
        /// The SeasonalEmployee() method is a Constructor for the SeasonalEmployee Class.
        /// This version of the constructor initializes all values to default (blank/0).
        /// </summary>
        public SeasonalEmployee()
        {
            SetFirstName("");
            SetLastName("");
            SetSIN("");
            SetDOB(new DateTime());
            string[] season = { "" };
            piecePay = "";
        }

        /// <summary>
        /// The SeasonalEmployee() method is a Constructor for the SeasonalEmployee Class.
        /// This version of the constructor initializes all values to input parameter values.
        /// </summary>
        /// <param name="first">The string to initialize the firstName variable to</param>
        /// <param name="last">The string to initialize the lastName variable to</param>
        /// <param name="SIN">The string to initialize the socialInsuranceNumber variable to</param>
        /// <param name="DOB">The date to initialize the dateOfBirth variable to</param>
        /// <param name="whatSeason">The string to initialize the season variable to</param>
        /// <param name="whatPiecePay">The string to initialize the piecePay variable to</param>
        public SeasonalEmployee(string first, string last, string SIN, DateTime DOB,
            string whatSeason, string whatPiecePay)
        {
            SetFirstName(first);
            SetLastName(last);
            SetSIN(SIN);
            SetDOB(DOB);
            season = whatSeason;
            piecePay = whatPiecePay;
        }

        /// <summary>
        /// The setter for the season variable
        /// </summary>
        /// <param name="whatSeason">The string indicating what value to set the season variable to</param>
        /// <returns></returns>
        public bool SetSeason(string whatSeason)
        {
            season = whatSeason;
            if (season == whatSeason)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// The setter for the piecePay variable
        /// </summary>
        /// <param name="whatPiecePay">The string indicating what value to set the piecePay variable to</param>
        /// <returns></returns>
        public bool SetPiecePay(string whatPiecePay)
        {
            piecePay = whatPiecePay;
            if (piecePay == whatPiecePay)
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
                season + "\n" +
                piecePay);
        }

        /// <summary>
        /// Method ensures that all current attribute settings are in fact valid for this employee type
        /// **logs the employee’s name (lastName, firstName) and socialInsuranceNumber values as well as whether the object is valid or not**
        /// </summary>
        /// <returns></returns>
        public override bool Validate()
        {
            bool isValid = false;

            return isValid;
        }
    }
}
