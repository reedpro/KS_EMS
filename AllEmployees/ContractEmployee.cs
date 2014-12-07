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
        private Decimal fixedContractAmt;

        /// <summary>
        /// The ContractEmployee() method is a Constructor for the ContractEmployee Class.
        /// This version of the constructor initializes all values to default (blank/0).
        /// </summary>
        public ContractEmployee() : base()
        {
            contractStartDate = null;
            contractEndDate = null;
            fixedContractAmt = 0.00M;
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
            DateTime startDate, DateTime endDate, Decimal rate)
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
        public Decimal GetFixedContractAmt()
        {
            return fixedContractAmt;
        }

        public bool SetContractStartDate(DateTime? cStartDate)
        {
            bool retV = false;
            log.writeLog(
                produceLogString("SET",
                                (contractStartDate.HasValue ? contractStartDate.Value.ToString("yyyy-MM-dd") : "N/A"),
                                (cStartDate.HasValue ? cStartDate.Value.ToString("yyyy-MM-dd") : "N/A"),
                                "SUCCESS"));
            contractStartDate = cStartDate;
            retV = true;
            return retV;
        }

        public bool SetContractStartDate(String cStartDateStr)
        {
            bool retV = false;
            DateTime? date = null;
            if (cStartDateStr == "N/A")
            {
                retV = SetContractStartDate(date);
                retV = true;
            }
            else if ((date = ReturnDateIfValid(cStartDateStr)) != null)
            {
                retV = SetContractStartDate(date);
                retV = true;
            }
            return retV;
        }
        public bool SetContractEndDate(DateTime? cEndDate)
        {
            bool retV = false;
            log.writeLog(
                produceLogString("SET",
                                (contractEndDate.HasValue ? contractEndDate.Value.ToString("yyyy-MM-dd") : "N/A"),
                                (cEndDate.HasValue ? cEndDate.Value.ToString("yyyy-MM-dd") : "N/A"),
                                "SUCCESS"));
            contractEndDate = cEndDate;
            retV = true;
            return retV;
        }

        public bool SetContractEndDate(String cEndDateStr)
        {
            bool retV = false;
            DateTime? date = null;
            if (cEndDateStr == "N/A")
            {
                retV = SetContractEndDate(date);
                retV = true;
            }
            else if ((date = ReturnDateIfValid(cEndDateStr)) != null)
            {
                retV = SetContractEndDate(date);
                retV = true;
            }
            return retV;
        }




        public bool CheckFixedContractAmt(Decimal fAmt)
        {
            return fAmt > 0;
        }

        public bool CheckFixedContractAmt(String fAmtStr)
        {
            Decimal newFixedAmount;
            return Decimal.TryParse(fAmtStr, out newFixedAmount) && CheckFixedContractAmt(newFixedAmount);
        }

        public bool SetFixedContractAmt(Decimal fAmt)
        {
            bool retV = false;
            if (CheckFixedContractAmt(fAmt) == true)
            {
                log.writeLog(produceLogString("SET", fixedContractAmt.ToString("0.00"), fAmt.ToString("0.00"), "SUCCESS"));
                fixedContractAmt = fAmt;
                retV = true;
            }
            else
            {
                log.writeLog(produceLogString("SET", fixedContractAmt.ToString("0.00"), fAmt.ToString("0.00"), "FAIL")
                    + "\nDetail: Fixed Contract Amoung cannot be lower than zero");
            }
            return retV;
        }

        public bool SetFixedContractAmt(String fAmtStr)
        {
            bool retV = false;
            Decimal newFixedContractAmt;
            if (Decimal.TryParse(fAmtStr, out newFixedContractAmt))
            {
                SetFixedContractAmt(newFixedContractAmt);
                retV = true;
            }
            return retV;
        }


       
    }
}
