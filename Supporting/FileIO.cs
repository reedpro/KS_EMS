using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;
using System.Reflection;


namespace Supporting
{
    /// <summary>
    /// This class is meant to read and write to the Employee database.
    /// </summary>
    public class FileIO
    {
        string dbasePath = Directory.GetCurrentDirectory();

        /// <summary>
        /// Holds a database file for reading
        /// </summary>
        private StreamReader dBase_R;

        /// <summary>
        /// holds a database file for writing
        /// </summary>
        private StreamWriter dBase_W;

        /// <summary>
        /// Opens a file for reading based on a path provided
        /// </summary>
        /// <param name="path">A string containing the path of the file to open</param>
        public void dBaseOpen_R()
        {
            if (File.Exists(dbasePath))
            {
                //open the file for reading, making sure it exists
                dBase_R = new StreamReader(File.OpenRead(dbasePath));
                // extract dbase info                
            }
            else
            {
                //file doesn't exist
            }
        }

        /// <summary>
        /// Opens a file for writing based on a path provided
        /// </summary>
        /// <param name="path">A string containing the path of the file to open</param>
        public void dBaseOpen_W(string[] employeeData)
        {
            // create the DBase folder if it doesn't already exist
            if (!Directory.Exists(Path.Combine(dbasePath, "DBase")))
            {
                Directory.CreateDirectory(Path.Combine(dbasePath, "DBase"));
            }
            //open file for writing, creating it if it doesnt exist TODO
            dBase_W = new StreamWriter(File.OpenWrite(Path.Combine(dbasePath, "Dbase", "DB.csv")));
            // write to dbase file
        }
    }
}
