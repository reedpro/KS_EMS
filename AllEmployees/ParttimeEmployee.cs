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

        /// <summary>
        /// The setter for dateOfHire
        /// </summary>
        /// <param name="date">The date to set the dateOfHire variable to</param>
        /// <returns>A boolean indicating whether the setting operation was successful</returns>
        public bool SetDateOfHire(DateTime? hDate)
        {
            bool retV = false;
            //if (fte.SetDateOfHire(hDate))
            //{
            //    dateOfHire = hDate;
            //    log.writeLog(
            //    produceLogString("SET",
            //                    (dateOfHire.HasValue ? dateOfHire.Value.ToString("yyyy-MM-dd") : "N/A"),
            //                    (hDate.HasValue ? hDate.Value.ToString("yyyy-MM-dd") : "N/A"),
            //                    "SUCCESS"));
            //}

            return retV;
        }

        /// <summary>
        /// The setter for dateOfTermination
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
        /// The setter for hourlyRate
        /// </summary>
        /// <param name="rate">The value to set the hourlyRate variable to</param>
        /// <returns>A boolean indicating whether the setting operation was successful</returns>
        public bool SetHourlyRate(Decimal rate)
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
                dateOfHire + "\n" +
                dateOfTermination + "\n" +
                hourlyRate);
        }
    }
}
