using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
