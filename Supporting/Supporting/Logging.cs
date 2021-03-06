﻿using System;
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
    class Logging
    {
        /// <summary>
        /// Opens the log for the day
        /// </summary>
        /// <returns>FileStream object of log file</returns>
        public FileStream openLog()
        {
            //TODO: actually open a file. Doesnt take paramater because it will always be the same file
            FileStream log = new FileStream();
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

            return true;
        }
    }
}
