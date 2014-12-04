using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Supporting
{
    /// <summary>
    /// Logs events from other classes in this project
    /// </summary>
    public class Logging
    {
        //private StreamWriter log = null;

        /// <summary>
        /// Opens the log for the day
        /// </summary>
        /// <returns>streamWriter object of log file</returns>
        public StreamWriter openLog(string path)
        {
            //TODO: actually open a file. Doesnt take paramater because it will always be the same file
            StreamWriter log = new StreamWriter(path);
            return log;
        }

        /// <summary>
        /// closes the log file
        /// </summary>
        /// <returns>success or failure.</returns>
        public bool closeLog()
        {
            return true;
        }


        /// <summary>
        /// Writes an entry to the log
        /// </summary>
        /// <param name="logEvent">string containing event to write</param>
        /// <returns>Bool indicating success or failure</returns>
        public bool writeLog(string logEvent)
        {
            // store the current date as "yyyy-mm-dd"
            string currentDate = DateTime.Now.ToString("yyyy-MM-dd", System.Globalization.CultureInfo.GetCultureInfo("en-US"));
            
            // create .log filename with current date (formatted "ems.YYYY-MM-DD.log")
            string fileName = "ems." + currentDate + ".log";

            using (StreamWriter w = File.AppendText(fileName))
            {
                // log the event in the right format
            }
            return true;
        }
    }
}
