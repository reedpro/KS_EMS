﻿//
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
        public ParttimeEmployee() : base()
        {
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
            : base(first, last, SIN, DOB)
        {
            dateOfHire = hDate;
            dateOfTermination = tDate;
            hourlyRate = rate;
        }
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


        private bool validateDOH()
        {
            bool retV = false;
            if (dateOfHire == null)
            {
                log.writeLog(produceLogString("VALIDATE", "", "N/A", "FAIL")
                                            + "\nDetails: Date of Hire cannot be NULL");
            }
            else
            {
                DateTime newDOH = (DateTime)dateOfHire;
                DateTime DOH_MaxDate = (dateOfBirth.HasValue ? (DateTime)dateOfBirth : DateTime.Now);
                if (CheckDateRange(DateTime.MinValue, DOH_MaxDate, newDOH) == true)
                {
                    log.writeLog(
                        produceLogString("VALIDATE", "", DateTime.Now.ToString("yyyy-MM-dd"), "SUCCESS")
                                        + "\nDetails: Date Of Hire comes before " + DOH_MaxDate.ToString("yyyy-MM-dd"));
                    retV = true;
                }
                else
                {
                    log.writeLog(
                        produceLogString("VALIDATE", "", DateTime.Now.ToString("yyyy-MM-dd"), "FAIL")
                                        + "\nDetails: Date Of Hire must come before " + DOH_MaxDate.ToString("yyyy-MM-dd"));
                }
            }
            return retV;
        }
        private bool validateDOT()
        {
            bool retV = false;
            if (dateOfTermination == null)
            {
                log.writeLog(produceLogString("VALIDATE", "", "N/A", "SUCCESS"));
                retV = true;
            }
            else
            {
                DateTime DOT_MinDate = (dateOfHire.HasValue ? (DateTime)dateOfHire
                                                             : (dateOfBirth.HasValue
                                                                        ? (DateTime)dateOfBirth
                                                                        : DateTime.Now));

                if (CheckDateRange(DOT_MinDate, DateTime.MaxValue, (DateTime)dateOfTermination) == true)
                {
                    log.writeLog(
                        produceLogString("VALIDATE", "", ((DateTime)dateOfTermination).ToString("yyyy-MM-dd"), "SUCCESS")
                                        + "\nDetails: Date Of Hire comes after " + DOT_MinDate.ToString("yyyy-MM-dd"));
                    retV = true;
                }
                else
                {
                    log.writeLog(
                        produceLogString("VALIDATE", "", ((DateTime)dateOfTermination).ToString("yyyy-MM-dd"), "FAIL")
                                        + "\nDetails: Date Of Hire must come after " + DOT_MinDate.ToString("yyyy-MM-dd"));
                }
            }
            return retV;
        }
        private bool validateHourlyRate()
        {
            bool retV = false;

            if (CheckHourlyRate(hourlyRate) && hourlyRate != 0)
            {
                log.writeLog(produceLogString("VALIDATE", "", hourlyRate.ToString("0.00"), "SUCCESS"));
                retV = true;
            }
            else
            {
                log.writeLog(produceLogString("VALIDATE", "", hourlyRate.ToString("0.00"), "FAIL") + "\nDetails: Hourly Rate must be bigger than 0");

            }
            return retV;
        }

        public override bool Validate()
        {
            return base.Validate() && validateDOH() && validateDOT() && validateHourlyRate();
        }

        protected override String ConsoleDetails()
        {
            String output = "";
            output += "\tDate of Hire:\t\t" + (dateOfHire.HasValue ? dateOfHire.Value.ToString("yyyy-MM-dd") : "N/A");
            output += "\tDate of Termination:\t" + (dateOfHire.HasValue ? dateOfHire.Value.ToString("yyyy-MM-dd") : "N/A");
            output += "\tHourly Rate:\t\t" + hourlyRate.ToString("0.00");
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
