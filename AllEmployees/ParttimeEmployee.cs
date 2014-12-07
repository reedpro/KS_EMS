//
// FILE: ParttimeEmployee.cs
// PROJECT: Employee Management System Project
// PROGRAMMERS: Jay Moorhouse, Jordan Poirier, Thom Taylor, Rachel Park
// DATE: 11/13/2014
// DESCRIPTION: Contains the class definition for the ParttimeEmployee child class.
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
    /// The ParttimeEmployee Class, a child class of Employee
    /// </summary>
    public sealed class ParttimeEmployee : Employee
    {
        private DateTime? dateOfHire;
        private DateTime? dateOfTermination;
        private Decimal hourlyRate;

        //public FulltimeEmployee fte;
        public DateTime? GetDateOfHire()
        {
            return dateOfHire;
        }
        public DateTime? GetDateOfTermination()
        {
            return dateOfTermination;
        }

        public Decimal GetHourlyRate()
        {
            return hourlyRate;
        }

        /// <summary>
        /// The ParttimeEmployee() method is a Constructor for the ParttimeEmployee Class.
        /// This version of the constructor initializes all values to default (blank/0).
        /// </summary>
        public ParttimeEmployee()
        {
            SetFirstName("");
            SetLastName("");
            SetSIN("");
            SetDOB(new DateTime());
            dateOfHire = null;
            dateOfTermination = null;
            hourlyRate = 0.00M;

            //fte = new FulltimeEmployee();
        }

        /// <summary>
        /// The ParttimeEmployee() method is a Constructor for the ParttimeEmployee Class.
        /// This version of the constructor initializes all values to input parameter values.
        /// </summary>
        /// <param name="first">The string to initialize the firstName variable to</param>
        /// <param name="last">The string to initialize the lastName variable to</param>
        /// <param name="SIN">The string to initialize the socialInsuranceNumber variable to</param>
        /// <param name="DOB">The date to set the dateOfBirth variable to</param>
        /// <param name="hireDate">The date to set the dateOfHire variable to</param>
        /// <param name="terminationDate">The date to set the dateOfTermination variable to</param>
        /// <param name="rate">The value to set the hourlyRate variable to</param>
        public ParttimeEmployee(String first, String last, String SIN, DateTime? DOB, DateTime? hDate, DateTime? tDate, Decimal rate)
        {
            SetFirstName(first);
            SetLastName(last);
            SetSIN(SIN);
            SetDOB(DOB);
            dateOfHire = hDate;
            dateOfTermination = tDate;
            hourlyRate = rate;

            //fte = new FulltimeEmployee(first, last, SIN, DOB, hDate, tDate, 0.00M);
        }

        public bool SetDateOfHire(String hDateStr)
        {
            bool retV = false;
            DateTime? date = null;
            if (hDateStr == "N/A")
            {
                retV = SetDateOfHire(date);
                retV = true;
            }
            else if ((date = ReturnDateIfValid(hDateStr)) != null)
            {
                retV = SetDateOfHire(date);
                retV = true;
            }
            return retV;
        }

        public bool SetDateOfTermination(String tDateStr)
        {
            bool retV = false;
            DateTime? date = null;
            if (tDateStr == "N/A")
            {
                retV = SetDateOfTermination(date);
                retV = true;
            }
            else if ((date = ReturnDateIfValid(tDateStr)) != null)
            {
                retV = SetDateOfTermination(date);
                retV = true;
            }
            return retV;
        }


        /// <summary>
        /// The setter for dateOfHire
        /// </summary>
        /// <param name="date">The date to set the dateOfHire variable to</param>
        /// <returns>A boolean indicating whether the setting operation was successful</returns>
        public bool SetDateOfHire(DateTime? hDate)
        {
            bool retV = false;
            log.writeLog(
                produceLogString("SET",
                                (dateOfHire.HasValue ? dateOfHire.Value.ToString("yyyy-MM-dd") : "N/A"),
                                (hDate.HasValue ? hDate.Value.ToString("yyyy-MM-dd") : "N/A"),
                                "SUCCESS"));
            dateOfHire = hDate;
            retV = true;
            return retV;
        }

        /// <summary>
        /// The setter for dateOfTermination
        /// </summary>
        /// <param name="date">The date to set the dateOfTermination variable to</param>
        /// <returns>A boolean indicating whether the setting operation was successful</returns>
        public bool SetDateOfTermination(DateTime? tDate)
        {
            bool retV = false;
            log.writeLog(
                produceLogString("SET",
                                (dateOfTermination.HasValue ? dateOfTermination.Value.ToString("yyyy-MM-dd") : "N/A"),
                                (tDate.HasValue ? tDate.Value.ToString("yyyy-MM-dd") : "N/A"),
                                "SUCCESS"));
            dateOfTermination = tDate;
            retV = true;
            return retV;
        }

        public bool CheckHourlyRate(Decimal hRate)
        {
            return hRate > 0;
        }

        public bool CheckHourlyRate(String hRateStr)
        {
            Decimal newSal;
            return Decimal.TryParse(hRateStr, out newSal) && CheckHourlyRate(newSal);
        }

        public bool SetHourlyRate(Decimal hRate)
        {
            bool retV = false;
            if (CheckHourlyRate(hRate) == true)
            {
                log.writeLog(produceLogString("SET", hourlyRate.ToString("0.00"), hRate.ToString("0.00"), "SUCCESS"));
                hourlyRate = hRate;
                retV = true;
            }
            else
            {
                log.writeLog(produceLogString("SET", hourlyRate.ToString("0.00"), hRate.ToString("0.00"), "FAIL")
                    + "\nDetail: Hourly Rate cannot be lower than zero");
            }
            return retV;
        }

        /// <summary>
        /// The setter for salary
        /// </summary>
        /// <param name="hRateStr">The string to set the salary variable to</param>
        /// <returns>A boolean indicating whether the setting operation was successful</returns>
        public bool SetHourlyRate(String hRateStr)
        {
            bool retV = false;
            Decimal newSal;
            if (Decimal.TryParse(hRateStr, out newSal))
            {
                SetHourlyRate(newSal);
                retV = true;
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
                dateOfHire + "\n" +
                dateOfTermination + "\n" +
                hourlyRate);
        }
    }
}
