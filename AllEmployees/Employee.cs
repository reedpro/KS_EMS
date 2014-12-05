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
        private String employeeType; /// Employee Type

        public Logging log;

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
            employeeType = "";

            log = new Logging();
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
            log = new Logging();
        }

        /// <summary>
        /// Overloaded Employee constructor.
        /// This version of the constructor sets all variables to the input parameter values.
        /// </summary>
        /// <param name="first">The string to initialize the firstName variable to</param>
        /// <param name="last">The string to initialize the lastName variable to</param>
        /// <param name="SIN">The string to set initialize socialInsuranceNumber variable to</param>
        /// <param name="DOB">The string to initialize the dateOfBirth variable to</param>
        public Employee(string first, string last, string SIN, DateTime DOB, String type)
        {
            firstName = first;
            lastName = last;
            socialInsuranceNumber = SIN;
            dateOfBirth = DOB;
            employeeType = type;

            log = new Logging();
        }

        public bool CheckName(String s)
        {
            bool retV = true;
            if (s != null)
            {
                for (int i = 0; i < s.Length; i++)
                {
                    if (!(Char.IsLetter(s[i]) || s[i] == '\'' || s[i] == '-'))
                    {
                        retV = false;
                        break;
                    }
                }
            }
            return retV;
        }
        public bool CheckDigit(String s)
        {
            bool retV = true;
            if (s != null)
            {
                for (int i = 0; i < s.Length; i++)
                {
                    if (!Char.IsDigit(s[i]))
                    {
                        retV = false;
                        break;
                    }
                }
            }
            return retV;
        }


        // reference http://www.fakenamegenerator.com/social-insurance-number.php
        // http://www.ryerson.ca/JavaScript/lectures/forms/textValidation/sinProject.html
        // http://stackoverflow.com/questions/17953014/c-sharp-algorithm-to-create-fake-canadian-social-secutiry-number-sin-for-unit
        public bool CheckSIN(String sin)
        {
            bool retV = false;
            sin = sin.Trim();
            sin = sin.Replace(" ", "");

            //basic validations
            if (sin.Length != 9)
            {
                if (sin == "") retV = true;
            }
            else if ((CheckDigit(sin))
                   || (sin[0] != '0')) //Canadian SIN number doesn't start with 0
            {
                int multiplier = 0;
                int sum = 0;
                foreach (int d in sin.Select(c => (int)c))
                {
                    // multiply odd position with 1, even with 2
                    // add each digit of the resulting number and get the total of resulting digits
                    sum += (d * ((multiplier % 2) + 1)).ToString().Select(c => (int)c).Sum();
                    multiplier++;
                }
                if ((sum + sin[8]) % 10 == 0)  // if the sum and the last digit of sin number is a multiple of 10, valid sin
                {
                    retV = true;
                }
            }
            //else false;

            return retV;
        }

        public bool CheckDateRange(DateTime startDate, DateTime endDate, DateTime inputDate)
        {
            bool retV = false;
            if (startDate <= endDate)
            {
                retV = ((inputDate >= startDate) && (inputDate <= endDate));
            }
            return retV;
        }

        public String produceLogString(String action, String iniValue, String endValue, String result)
        {
            String logStr = "";
            if (action.ToUpper() == "SET")
            {
                logStr = "Action: " + action.ToUpper() + "_" + result.ToUpper() + "\nPrevious: " + iniValue + "\tInput: " + endValue;
            }
            else if (action.ToUpper() == "VALIDATE")
            {
                logStr = "Action: " + action.ToUpper() + "_" + result.ToUpper() + "\nInput: " + endValue;
            }
            else if (action.ToUpper() == "VALIDATE")
            {
                logStr = "Action: " + action.ToUpper() + "_" + result.ToUpper();
            }
            return logStr;
        }


        /// <summary>
        /// The setter for firstName
        /// </summary>
        /// <param name="fName">The string to set the firstName variable to</param>
        /// <returns>A boolean indicating whether the setting operation was successful</returns>
        public bool SetFirstName(string fName)
        {
            bool retV = false;
            if (this.employeeType.ToUpper() == "CT")
            {
                log.writeLog(produceLogString("SET", firstName, fName, "FAIL") + "\nDetail: Contract Employee has blank first name");
            }
            else
            {
                if (CheckName(fName) == true)
                {
                    log.writeLog(produceLogString("SET", firstName, fName, "SUCCESS"));
                    firstName = fName;
                    retV = true;
                }
                else
                {
                    log.writeLog(produceLogString("SET", firstName, fName, "FAIL") + "\nDetail: Contains invalid characters");
                }
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
            if (CheckName(lName) == true)
            {
                log.writeLog(produceLogString("SET", lastName, lName, "SUCCESS"));
                firstName = lName;
                retV = true;
            }
            else
            {
                log.writeLog(produceLogString("SET", lastName, lName, "FAIL") + "\nDetail: Contains invalid characters");
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
            if (CheckSIN(SIN) == true)
            {
                log.writeLog(produceLogString("SET", socialInsuranceNumber, SIN, "SUCCESS"));
                socialInsuranceNumber = SIN;
                retV = true;
            }
            else
            {
                log.writeLog(produceLogString("SET", socialInsuranceNumber, SIN, "FAIL"));
            }
            return retV;
        }

        /// <summary>
        /// The setter for dateOfbirth
        /// </summary>
        /// <param name="dob">The string to set the dateOfBirth to</param>
        /// <returns>A boolean indicating whether the setting operation was successful</returns>
        public bool SetDOB(DateTime dob)
        {
            bool retV = false;
            if (CheckDateRange(new DateTime(0), DateTime.Now, dob) == true)
            {
                log.writeLog(produceLogString("SET", dateOfBirth.ToString("yyyy-MM-dd"), dob.ToString("yyyy-MM-dd"), "SUCCESS"));
                dateOfBirth = dob;
                retV = true;
            }
            else
            {
                log.writeLog(produceLogString("SET", dateOfBirth.ToString("yyyy-MM-dd"), dob.ToString("yyyy-MM-dd"), "FAIL"));
            }
            return retV;
        }

        public bool SetType(String type)
        {
            employeeType = type;
            return true;
        }

        public virtual bool Validate()
        {
            return validateFirstName() && validateLastName() && validateDOB() && validateDOB();
        }

        private bool validateFirstName()
        {
            bool retV = false;
            if (firstName != null)
            {
                if (firstName == "")
                {
                    if (employeeType.ToUpper() == "CT")
                    {
                        log.writeLog(produceLogString("VALIDATE", "", firstName, "SUCCESS"));
                        retV = true;
                    }
                    else
                    {
                        log.writeLog(produceLogString("VALIDATE", "", firstName, "FAIL") + "\nDetail: Name cannot be BLANK");
                    }
                }
                else
                {
                    if (CheckName(firstName) == true)
                    {
                        log.writeLog(produceLogString("VALIDATE", "", firstName, "SUCCESS"));
                        retV = true;
                    }
                    else
                    {
                        log.writeLog(produceLogString("VALIDATE", "", firstName, "FAIL") + "\nDetail: Name contains invalid characters");
                    }
                }
            }
            else
            {
                log.writeLog(produceLogString("VALIDATE", "", firstName, "FAIL") + "\nDetail: Name cannot be NULL");
            }
            return retV;
        }
        private bool validateLastName()
        {
            bool retV = false;
            if (lastName != null)
            {
                if (lastName == "")
                {
                    log.writeLog(produceLogString("VALIDATE", "", lastName, "FAIL") + "\nDetail: Name cannot be BLANK");
                }
                else
                {
                    if (CheckName(lastName) == true)
                    {
                        log.writeLog(produceLogString("VALIDATE", "", lastName, "SUCCESS"));
                        retV = true;
                    }
                    else
                    {
                        log.writeLog(produceLogString("VALIDATE", "", lastName, "FAIL") + "\nDetail: Name contains invalid characters");
                    }
                }
            }
            else
            {
                log.writeLog(produceLogString("VALIDATE", "", lastName, "FAIL") + "\nDetail: Name cannot be NULL");
            }
            return retV;
        }
        private bool validateDOB()
        {
            bool retV = false;
            if (CheckDateRange(new DateTime(0), DateTime.Now, dateOfBirth) == true)
            {
                log.writeLog(produceLogString("VALIDATE", "", dateOfBirth.ToString("yyyy-MM-dd"), "SUCCESS"));
                retV = true;
            }
            else
            {
                log.writeLog(produceLogString("VALIDATE", "", dateOfBirth.ToString("yyyy-MM-dd"), "FAIL"));
            }
            return retV;
        }
        private bool validateSIN()
        {
            bool retV = false;
            if (CheckSIN(socialInsuranceNumber) == true)
            {
                log.writeLog(produceLogString("VALIDATE", "", socialInsuranceNumber, "SUCCESS"));
                retV = true;
            }
            else
            {
                log.writeLog(produceLogString("VALIDATE", "", socialInsuranceNumber, "SUCCESS"));
            }
            return retV;
        }

        protected virtual String ConsoleDetails()
        {
            String output = "";
            if (employeeType != "CT")
            {
                switch (employeeType)
                {
                    case "FT":
                        output += "<Full Time Employee>\n";
                        goto default;
                    case "PT":
                        output += "<Part Time Employee>\n";
                        goto default;
                    case "SN":
                        output += "<Seasonal Employee>\n";
                        goto default;
                    default:
                        output += "\tLast Name:\t" + lastName;
                        output += "\tFirst Name:\t" + firstName;
                        output += "\tSIN:\t" + socialInsuranceNumber.Insert(4, " ").Insert(8, " ");
                        output += "\tDate of Birth:\t" + dateOfBirth.ToString("yyyy-MM-dd");
                        break;
                }
            }
            else
            {
                output += "<Contract Employee>\n";
                output += "\tBusiness Name:\t\t" + lastName;
                output += "\tBusiness Number:\t\t" + socialInsuranceNumber.Insert(5, " ");
                output += "\tDate of Incorporation:\t" + dateOfBirth.ToString("yyyy-MM-dd");
            }
            return output;
        }

        public virtual String DatabaseDetails()
        {
            String output = "";
            if (employeeType == "FT")
            {
                output += "FT|" + lastName + "|" + firstName + "|" + socialInsuranceNumber + "|" + dateOfBirth.ToString("yyyy-MM-dd") + "|";
            }
            else if (employeeType == "PT")
            {
                output += "PT|" + lastName + "|" + firstName + "|" + socialInsuranceNumber + "|" + dateOfBirth.ToString("yyyy-MM-dd") + "|";
            }
            else if (employeeType == "CT")
            {
                output += "CT|" + lastName + "|" + socialInsuranceNumber + "|" + dateOfBirth.ToString("yyyy-MM-dd") + "|";
            }
            else if (employeeType == "SN")
            {
                output += "SN|" + lastName + "|" + firstName + "|" + socialInsuranceNumber + "|" + dateOfBirth.ToString("yyyy-MM-dd") + "|";
            }

            return output;
        }

        public virtual void Details()
        {
            String consoleOutput = ConsoleDetails();
            Console.WriteLine(consoleOutput);
            log.writeLog(produceLogString("VALIDATE", "", "", "")  + "\nInput: \n" + consoleOutput);
        }
    }
}
