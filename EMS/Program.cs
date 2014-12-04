using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Supporting;
using AllEmployees;
using TheCompany;
using Presentation;


namespace EMS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Test Plan Due Soon!"); // darn! get to work team!
            Logging log = new Logging();
            log.writeLog("test!");
        }
    }
}
