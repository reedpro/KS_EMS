using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Supporting
{
    /// <summary>
    /// Validation Class to validate all input
    /// </summary>
    class Validation
    {
        /// <summary>
        /// Gets set each time the validation fails, detailing why it failed
        /// </summary>
        public string errorMsg { get; private set; }

        /// <summary>
        /// Validates a name string to ensure that it has no numbers and only accepted symbols
        /// </summary>
        /// <param name="inName">String to be validated</param>
        /// <returns>Bool indicating success</returns>
        public bool name(string inName)
        {
            bool returnVal = false;
            if(inName.Any(c => char.IsDigit(c)))
            {
                errorMsg = "A name cannot contain any numbers";
            }
            else
            {
                returnVal = true;
            }
            return returnVal;
        }

        public bool date(string inDate)
        {
            bool returnVal = false;
            DateTime newDate = default(DateTime);
            if (DateTime.TryParseExact(inDate, "yyyy-mm-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out newDate))
            {
                returnVal = true;
            }
            else
            {
                errorMsg = "The date must be entered in valid YYYY-MM-DD format";
            }
            return returnVal;
        }

        public bool rate(string inRate)
        {
            bool returnVal = false;
            decimal newRate;
            if(inRate.Any(c => char.IsSymbol(c) || char.IsLetter(c)))
            {
                errorMsg = "The rate must only contain a numeric value";
            }
            else
            {
                if (Decimal.TryParse(inRate, out newRate))
                {
                    if (newRate >= 0)
                    {
                        returnVal = true;
                    }
                    else
                    {
                        errorMsg = "The rate cannot be less than 0";
                    }
                }
                else
                {
                    errorMsg = "The string provided is not decimal";
                } 
            }
            return returnVal;
        }
    }
}
