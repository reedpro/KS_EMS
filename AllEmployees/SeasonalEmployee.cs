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
        private string season;
        private double piecePay;

        /// <summary>
        /// The SeasonalEmployee() method is a Constructor for the SeasonalEmployee Class.
        /// This version of the constructor initializes all values to default (blank/0).
        /// </summary>
        public SeasonalEmployee() : base()
        {
            SetSeason("");
            SetPiecePay(0);

            SetType("SN");
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
        public SeasonalEmployee(String first, String last, String SIN, DateTime? DOB, String whatSeason, double whatPiecePay) 
            : base(first, last, SIN, DOB)
        {
            SetSeason(whatSeason);
            SetPiecePay(whatPiecePay);
            SetType("SN");
        }

        public String GetSeason()
        {
            return season;
        }
        public Double GetPiecePay()
        {
            return piecePay;
        }




        /// <summary>
        /// Method checks if the input season is a valid season
        /// </summary>
        /// <param name="input">input string to be checked</param>
        /// <returns></returns>
        public bool CheckSeason(string input)
        {
            bool retV = false;
            string[] validSeasons = { "spring", "summer", "fall", "winter", "" };
            foreach (string s in validSeasons)
            {
                if (input.ToLower() == s)
                {
                    retV = true;
                }
            }
            return retV;
        }

        /// <summary>
        /// The setter for the season variable
        /// </summary>
        /// <param name="whatSeason">The string indicating what value to set the season variable to</param>
        /// <returns>A boolean indicating whether the setting operation was successful</returns>
        public bool SetSeason(string input)
        {
            bool retV = false;
            if (CheckSeason(input) == true)
            {
                log.writeLog(produceLogString("SET", season, input, "SUCCESS"));
                season = input;
                retV = true;
            }
            else
            {
                log.writeLog(produceLogString("SET", season, input, "FAIL") + "\nDetail:Invalid season");
            }
            return retV;
        }

        /// <summary>
        /// check the input piecepay for valid values
        /// </summary>
        /// <param name="input">String indicating piecepay to check</param>
        /// <returns>A boolean indicating whether the setting operation was successful</returns>
        public bool CheckPiecePay(double input)
        {
            bool retV = false;
            if (input >= 0)
            {
                retV = false;
            }
            return retV;
        }

        /// <summary>
        /// The setter for the piecePay variable
        /// </summary>
        /// <param name="whatPiecePay">The string indicating what value to set the piecePay variable to</param>
        /// <returns>A boolean indicating whether the setting operation was successful</returns>
        public bool SetPiecePay(double input)
        {
            bool retV = false;
            if (CheckPiecePay(input) == true)
            {
                log.writeLog(produceLogString("SET", piecePay.ToString("0.00"), input.ToString("0.00"), "SUCCESS"));
                piecePay = input;
                retV = true;
            }
            else
            {
                log.writeLog(produceLogString("SET", piecePay.ToString("0.00"), input.ToString("0.00"), "FAIL") + "\nDetail:Invalid piece pay format");
            }
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
                season + "\n" +
                piecePay);
        }
    }
}
