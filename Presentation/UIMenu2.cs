//
// FILE: UIMenu.cs
// PROJECT: Employee Management System Project
// PROGRAMMERS: Jay Moorhouse, Jordan Poirier, Thom Taylor, Rachel Park
// DATE: 11/13/2014
// DESCRIPTION: All input/output from/to the user will be handeled by the methods and properties
// defined in this class.
// 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Reflection;
using Supporting;
using TheCompany;
using AllEmployees;


namespace Presentation
{
    /// <summary>
    /// PurposeThis class will contain meathods to display
    /// Menus to the user. That the user will then interact with
    /// calling the functional meathods of the program
    /// </summary>
    public class UIMenu
    {
        ///<VAR choice="int">the choice made by the user 
        ///as a single number</VAR>
        ConsoleKeyInfo choice = new ConsoleKeyInfo();
        //string dBaseFile = Path.Combine(Directory.GetCurrentDirectory(), "DBase", "DB.csv");
        FileIO fileClass = new FileIO();
        Container company = new Container();
        Validation val = new Validation();
        Logging log = new Logging();

        ContractEmployee ctEmp = new ContractEmployee();
        FulltimeEmployee ftEmp = new FulltimeEmployee();
        SeasonalEmployee snEmp = new SeasonalEmployee();
        ParttimeEmployee ptEmp = new ParttimeEmployee();
        Employee baseEmp = new Employee();

        bool mainMenu = false;
        char empType = 'x';
        string input = "";


        public void MenuOne()
        {
            ///To DO: 
            ///Call to Validate Number() is in range
            while (true)
            {
                mainMenu = false;
                Console.Clear();
                Console.WriteLine("Menu 1: Main Menu");
                Console.WriteLine("1. Manage EMS DBase Files");
                Console.WriteLine("2. Manage Employees");
                Console.WriteLine("9. Quit");

                choice = Console.ReadKey();
                if (choice.KeyChar == '1')  //Manage EMS DB File
                {
                    MenuTwo();
                    break;
                }
                else if (choice.KeyChar == '2') //Manage Employees
                {
                    MenuThree();
                    break;
                }
                else if (choice.KeyChar == '9') //Quit
                {
                    //TO DO:
                    //Ask if want to quit for sure
                    break;
                }
            }

        }


        public void MenuTwo()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Menu 2: File Managment Menu");
                Console.WriteLine("1. Load EMS DBase From File");
                Console.WriteLine("2. Save Employee set to EMS Dbase");
                Console.WriteLine("9. Return To Main Menu ");
                choice = Console.ReadKey();
                if (choice.KeyChar == '1')
                {
                    ///Display File List (option to feed the file name to loadcontainer??)
                    company.LoadContainer();
                    break;
                }

                else if (choice.KeyChar == '2')
                {
                    ///Call to WriteFile()
                    company.SaveContainer();
                    break;
                }

                else if (choice.KeyChar == '9')
                {
                    MenuOne();
                    break;
                }
            }

        }

        public void MenuThree()
        {
            ///<VAR manType = "String">The users specified type of manipulation
            ///either to create or Remove an Employee</Var>
            String manType = "";
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Menu 3: Employee Managment Menu");
                Console.WriteLine("1. Display Employee Set");
                Console.WriteLine("2. Create a NEW Employee");
                Console.WriteLine("3. Modify an EXISTING Employee ");
                Console.WriteLine("4. Remove an EXISTING Employee");
                Console.WriteLine("9. Return to Main Menu");

                choice = Console.ReadKey();
                if (choice.KeyChar == '1')
                {
                    ///Traverse Employees Set and Call Details()
                }
                else if (choice.KeyChar == '2')
                {
                    manType = "Create";
                    //MenuFour(manType);
                    break;
                }

                else if (choice.KeyChar == '3')
                {
                    manType = "Remove";
                    //MenuFour(manType);
                    break;
                }
                else if (choice.KeyChar == '4')
                {
                    Console.WriteLine("Are You Sure You Would Like To Remove Employee?");
                    Console.WriteLine("Press 1 for YES.");
                    Console.WriteLine("Press 2 for NO.");
                    if (choice.KeyChar == '1')
                    {
                        ///TO DO Call RemoveEmployee()
                        Console.WriteLine("Employee Removed Successfully.");
                        MenuThree();
                        break;
                    }
                    else if (choice.KeyChar == '2')
                    {
                        Console.WriteLine("Employee Was NOT Removed");
                        MenuThree();
                        break;
                    }
                }
                else if (choice.KeyChar == '9')
                {
                    break;
                }
            }
        }

       

        
        public void PrintMenuFourOptions(String type)
        {
            Console.Clear();
            Console.WriteLine("Menu 4: Employee Details Menu");
            Console.WriteLine("1. Specify Base Employee Details");

            switch (type)
            {
                case "FT":
                    Console.WriteLine("2. Set Full Time Employee Date Of Hire");
                    Console.WriteLine("3. Set Full Time Employee Date Of Termination");
                    Console.WriteLine("4. Set Full Time Employee Salary");
                    goto default;
                case "PT":
                    Console.WriteLine("2. Set Part Time Employee Date Of Hire");
                    Console.WriteLine("3. Set Part Time Employee Date Of Termination");
                    Console.WriteLine("4. Set Part Time Employee Hourly rate");
                    goto default;
                case "CT":
                    Console.WriteLine("2. Set Contract Employee Contract Start Date");
                    Console.WriteLine("3. Set Contract Employee Contract Stop Date");
                    Console.WriteLine("4. Set Contract Employee Fixed Contract Amount");
                    goto default;
                case "SN":
                    Console.WriteLine("2. Set Seasonal Employee Season");
                    Console.WriteLine("3. Set Seasonal Employee Piece Pay");
                    goto default;
                default:
                    Console.WriteLine("");
                    Console.WriteLine("6. Preview Employee Data Entered So Far");
                    Console.WriteLine("7. Discard Employee Data Entered So Far");
                    Console.WriteLine("8. Add Employee Data Entered to Employee Set");
                    Console.WriteLine("9. Return to Employee Management Menu");
                    break;
            }
        }

        public String SpecifyNameOrRateOrDateOrSIN(String what, String question)
        {
            String input = "";
            Console.Clear();
            Console.WriteLine(question);
            Console.Write("\t>> " + what + ":\t");
            input = Console.ReadLine();
            input = input.Trim();
            return input;
        }

        public String SpecifySeason()
        {
            String input = "";

            Console.Clear();
            Console.WriteLine("Specify Season for the Contract Employee");
            Console.WriteLine("\t1. Winter");
            Console.WriteLine("\t2. Spring");
            Console.WriteLine("\t3. Summer");
            Console.WriteLine("\t4. Fall");
            char c = Console.ReadKey().KeyChar;
            switch(c)
            {
                case '1':
                    input = "WINTER";
                    break;
                case '2':
                    input = "SPRING";
                    break;
                case '3':
                    input = "SUMMER";
                    break;
                case '4':
                    input = "FALL";
                    break;
            }
            return input;
        }

        public Employee SpecifiyBaseEmployee(String type)
        {
            String fName, lName, dob, SIN;
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Menu 4.1: Specify Base Employee Details");
                if (type != "Contract")
                {
                    Console.WriteLine("1. Set Firt Name");
                }
                Console.WriteLine("2. Set Last Name");
                Console.WriteLine("3. Set Date Of Birth");
                Console.WriteLine("4. Set Social Insurance Number");
                Console.WriteLine("5. Go Back to Employee Details Menu");
                choice = Console.ReadKey();
                if ((choice.KeyChar == '1') && (type != "Contract"))
                {
                    fName = SpecifyNameOrRateOrDateOrSIN("First Name", "Please Enter First Name of " + type);
                    Console.WriteLine("You wrote " + fName);
                    if(baseEmp.SetFirstName(fName))
                    {
                        Console.WriteLine("First Name Successfully Set to " + baseEmp.GetFirstName());
                        baseEmp.Details();
                    }
                    else
                    {
                        Console.WriteLine("Failed to Set First Name to \"" + fName + "\"; Remain as \"" + baseEmp.GetFirstName() + "\"");
                    }
                }
                else if(choice.KeyChar == '2')
                {
                    lName = SpecifyNameOrRateOrDateOrSIN("Last Name", "Please Enter Last Name of " + type);
                    if (baseEmp.SetFirstName(lName))
                    {
                        Console.WriteLine("Last Name Successfully Set to " + baseEmp.GetLastName());
                    }
                    else
                    {
                        Console.WriteLine("Failed to Set Last Name to \"" + lName + "\"; Remain as \"" + baseEmp.GetLastName() + "\"");
                    }
                }
                else if (choice.KeyChar == '3')
                {
                    dob = SpecifyNameOrRateOrDateOrSIN("Date of Birth", "Please Enter Date of Birth of " + type);
                    if (baseEmp.SetDOB(dob))
                    {
                        Console.WriteLine("Date of Birth Successfully Set to " + baseEmp.GetDOB());
                    }
                    else
                    {
                        Console.WriteLine("Failed to Set Date of Birth to \"" + dob + "\"; Remain as \"" + baseEmp.GetDOB() + "\"");
                    }
                }
                else if (choice.KeyChar == '4')
                {
                    SIN = SpecifyNameOrRateOrDateOrSIN("Social Insurance Number", "Please Enter SIN number of " + type);
                    if (baseEmp.SetDOB(SIN))
                    {
                        Console.WriteLine("SIN Number Successfully Set to " + baseEmp.GetDOB());
                    }
                    else
                    {
                        Console.WriteLine("Failed to Set SIN Number to \"" + SIN + "\"; Remain as \"" + baseEmp.GetSIN() + "\"");
                    }
                }
                else if (choice.KeyChar == '5')
                {
                    break;
                }
                Console.WriteLine("Press Any Key to Go Back to Previous Menu and Make Other Changes");
                Console.ReadKey();
            }
            return baseEmp;
        }



        public void MenuFourToCreate(String type)
        {
            while (true)
            {
                PrintMenuFourOptions(type);

                choice = Console.ReadKey();
                if (choice.KeyChar == '1')
                {
                    baseEmp = SpecifiyBaseEmployee(type);
                }
                else
                {
                    #region FULLTIME
                    if (type == "Full Time")
                    {
                        String hDateStr, tDateStr, salaryStr;
                        if (choice.KeyChar == '2')
                        {
                            hDateStr = SpecifyNameOrRateOrDateOrSIN("Hiring Date", "Please Enter Hiring Date of " + type);
                            if (ftEmp.SetDateOfHire(hDateStr))
                            {
                                Console.WriteLine("Hiring Date Successfully Set to " + ftEmp.GetDateOfHire());
                            }
                            else
                            {
                                Console.WriteLine("Failed to Set Hiring Date to \"" + hDateStr + "\"; Remain as \"" + ftEmp.GetDateOfHire() + "\"");
                            }
                        }
                        else if (choice.KeyChar == '3')
                        {
                            tDateStr = SpecifyNameOrRateOrDateOrSIN("Termination Date", "Please Enter Termination Date of " + type);
                            if (ftEmp.SetDateOfTermination(tDateStr))
                            {
                                Console.WriteLine("Termination Date Successfully Set to " + ftEmp.GetDateOfTermination());
                            }
                            else
                            {
                                Console.WriteLine("Failed to Set Termination Date to \"" + tDateStr + "\"; Remain as \"" + ftEmp.GetDateOfTermination() + "\"");
                            }
                        }
                        else if (choice.KeyChar == '4')
                        {
                            salaryStr = SpecifyNameOrRateOrDateOrSIN("Salary", "Please Enter Salary of " + type);
                            if (ftEmp.SetSalary(salaryStr))
                            {
                                Console.WriteLine("Salary Successfully Set to " + ftEmp.GetSalary());
                            }
                            else
                            {
                                Console.WriteLine("Failed to Set Salary to \"" + salaryStr + "\"; Remain as \"" + ftEmp.GetSalary() + "\"");
                            }
                        }
                    }//FULL TIME EMPLOYEE
                    #endregion
                    #region PARTTIME
                    else if (type == "Part Time")
                    {
                        String hDateStr, tDateStr, hourlyRateStr;
                        if (choice.KeyChar == '2')
                        {
                            hDateStr = SpecifyNameOrRateOrDateOrSIN("Hiring Date", "Please Enter Hiring Date of " + type);
                            if (ptEmp.SetDateOfHire(hDateStr))
                            {
                                Console.WriteLine("Hiring Date Successfully Set to " + ptEmp.GetDateOfHire());
                            }
                            else
                            {
                                Console.WriteLine("Failed to Set Hiring Date to \"" + hDateStr + "\"; Remain as \"" + ptEmp.GetDateOfHire() + "\"");
                            }
                        }
                        else if (choice.KeyChar == '3')
                        {
                            tDateStr = SpecifyNameOrRateOrDateOrSIN("Termination Date", "Please Enter Termination Date of " + type);
                            if (ptEmp.SetDateOfTermination(tDateStr))
                            {
                                Console.WriteLine("Termination Date Successfully Set to " + ptEmp.GetDateOfTermination());
                            }
                            else
                            {
                                Console.WriteLine("Failed to Set Termination Date to \"" + tDateStr + "\"; Remain as \"" + ptEmp.GetDateOfTermination() + "\"");
                            }
                        }
                        else if (choice.KeyChar == '4')
                        {
                            hourlyRateStr = SpecifyNameOrRateOrDateOrSIN("Hourly Rate", "Please Enter Salary of " + type);
                            if (ptEmp.SetHourlyRate(hourlyRateStr))
                            {
                                Console.WriteLine("Hourly Rate Successfully Set to " + ptEmp.GetHourlyRate());
                            }
                            else
                            {
                                Console.WriteLine("Failed to Set Hourly Rate to \"" + hourlyRateStr + "\"; Remain as \"" + ptEmp.GetHourlyRate() + "\"");
                            }
                        }
                    }//PART TIME EMPLOYEE
                    #endregion PARTTIME
                    else if (type == "Contract")
                    {
                        String cStartDateStr, cEndDateStr, fixedContractAmtStr;
                        if (choice.KeyChar == '2')
                        {
                            cStartDateStr = SpecifyNameOrRateOrDateOrSIN("Contract Start Date", "Please Enter Contract Start Date of " + type);
                            if (ctEmp.SetContractStartDate(cStartDateStr))
                            {
                                Console.WriteLine("Contract Start Date Successfully Set to " + ctEmp.GetContractStartDate());
                            }
                            else
                            {
                                Console.WriteLine("Failed to Set Contract Start Date to \"" + cStartDateStr + "\"; Remain as \"" + ctEmp.GetContractStartDate() + "\"");
                            }
                        }
                        else if (choice.KeyChar == '3')
                        {
                            cEndDateStr = SpecifyNameOrRateOrDateOrSIN("Contract End Date", "Please Enter Contract End Date of " + type);
                            if (ctEmp.SetContractEndDate(cEndDateStr))
                            {
                                Console.WriteLine("Contract End Date Successfully Set to " + ctEmp.GetContractEndDate());
                            }
                            else
                            {
                                Console.WriteLine("Failed to Set Contract End Date to \"" + cEndDateStr + "\"; Remain as \"" + ctEmp.GetContractEndDate() + "\"");
                            }
                        }
                        else if (choice.KeyChar == '4')
                        {
                            fixedContractAmtStr = SpecifyNameOrRateOrDateOrSIN("Fixed Contract Amount", "Please Enter Fixed Contract Amount of " + type);
                            if (ctEmp.CheckFixedContractAmt(fixedContractAmtStr))
                            {
                                Console.WriteLine("Contract Fixed Contract Amount Successfully Set to " + ctEmp.GetFixedContractAmt());
                            }
                            else
                            {
                                Console.WriteLine("Failed to Set Fixed Contract Amount to \"" + fixedContractAmtStr + "\"; Remain as \"" + ctEmp.GetFixedContractAmt() + "\"");
                            }
                        }
                    }

                    Console.WriteLine("Press Any Key to Go Back to Previous Menu and Make Other Changes");
                    Console.ReadKey();
                }
            }
        }
        public void MenuFourToModify(String SIN)
        {

        }

        #region jordan's code
        //public void MenuThree()
        //{
        //    ///<VAR manType = "String">The users specified type of manipulation
        //    ///either to create or Remove an Employee</Var>
        //    String manType = "";
        //    while (true)
        //    {
        //        Console.Clear();
        //        Console.WriteLine("Menu 3: Employee Managment Menu");
        //        Console.WriteLine("1. Display Employee Set");
        //        Console.WriteLine("2. Create a NEW Employee");
        //        Console.WriteLine("3. Modify an EXISTING Employee ");
        //        Console.WriteLine("4. Remove an EXISTING Employee");
        //        Console.WriteLine("9. Return to Main Menu");

        //        choice = Console.ReadKey();
        //        if (choice.KeyChar == '1')
        //        {
        //            ///Traverse Employees Set and Call Details()
        //        }
        //        else if (choice.KeyChar == '2')
        //        {
        //            manType = "Create";
        //            MenuFour(manType);
        //            break;
        //        }

        //        else if (choice.KeyChar == '3')
        //        {
        //            manType = "Remove";
        //            MenuFour(manType);
        //            break;
        //        }
        //        else if (choice.KeyChar == '4')
        //        {
        //            Console.WriteLine("Are You Sure You Would Like To Remove Employee?");
        //            Console.WriteLine("Press 1 for YES.");
        //            Console.WriteLine("Press 2 for NO.");
        //            if (choice.KeyChar == '1')
        //            {
        //                ///TO DO Call RemoveEmployee()
        //                Console.WriteLine("Employee Removed Successfully.");
        //                MenuThree();
        //                break;
        //            }
        //            else if (choice.KeyChar == '2')
        //            {
        //                Console.WriteLine("Employee Was NOT Removed");
        //                MenuThree();
        //                break;
        //            }
        //        }
        //        else if (choice.KeyChar == '9')
        //        {
        //            break;
        //        }
        //    }
        //}
        //public void MenuFour(String ManType)
        //{
        //    while (mainMenu != true)
        //    {
        //        if (ManType == "Remove")
        //        {
        //            ///TO DO: Call REMOVE();
        //        }

        //            ///Menu 4
        //        else if (ManType == "Create")
        //        {
        //            Console.Clear();
        //            Console.WriteLine("Menu 4: Employee Details Menu");
        //            Console.WriteLine("1. Specify Base Employee");
        //            Console.WriteLine("9. Return to Main Menu");

        //            choice = Console.ReadKey();
        //            if (choice.KeyChar == '1')
        //            {
        //                createBase();
        //            }

        //            if (choice.KeyChar == '9')
        //            {
        //                break;
        //            }
        //        }
        //    }
        //}
        //public void createBase()
        //{
        //    while (true)
        //    {
        //        Console.Clear();
        //        Console.WriteLine("Please Enter Employee Type ");
        //        Console.WriteLine("1. Full Time");
        //        Console.WriteLine("2. Part Tme");
        //        Console.WriteLine("3. Contract");
        //        Console.WriteLine("4. Seasonal");
        //        Console.WriteLine("9. Quit");
        //        choice = Console.ReadKey();
        //        if (choice.KeyChar == '1')
        //        {
        //            empType = 'f';
        //        }
        //        else if (choice.KeyChar == '2')
        //        {
        //            empType = 'p';
        //        }
        //        else if (choice.KeyChar == '3')
        //        {
        //            empType = 'c';
        //        }
        //        else if (choice.KeyChar == '4')
        //        {
        //            empType = 's';
        //        }
        //        else if (choice.KeyChar == '9')
        //        {
        //            break;
        //        }

        //        Console.Clear();
        //        while (true)
        //        {
        //            if (empType != 'c')
        //            {
        //                Console.WriteLine("Please Enter Last Name:");
        //            }
        //            else
        //            {
        //                Console.WriteLine("please Enter Company Name:");
        //            }
        //            input = Console.ReadLine();
        //            if (val.name(input))
        //            {
        //                baseEmp.SetLastName(input);
        //                break;
        //            }
        //            else
        //            {
        //                log.writeLog(input + ": " + val.errorMsg);
        //                Console.WriteLine(input + ": " + val.errorMsg);
        //            }
        //        }
        //        if (empType != 'c')
        //        {
        //            while (true)
        //            {
        //                Console.WriteLine("Please Enter First name:");
        //                input = Console.ReadLine();
        //                if (val.name(input))
        //                {
        //                    baseEmp.SetFirstName(input);
        //                    break;
        //                }
        //                else
        //                {
        //                    log.writeLog(input + ": " + val.errorMsg);
        //                    Console.WriteLine(input + ": " + val.errorMsg);
        //                }
        //            }
        //        }
        //        while (true)
        //        {
        //            if (empType != 'c')
        //            {
        //                Console.WriteLine("Plese Enter SIN");
        //            }
        //            else
        //            {
        //                Console.WriteLine("Plese Enter BIN");
        //            }
        //            input = Console.ReadLine();
        //            if (val.sin(input))
        //            {
        //                baseEmp.SetSIN(input);
        //                break;
        //            }
        //            else
        //            {
        //                log.writeLog(input + ": " + val.errorMsg);
        //                Console.WriteLine(input + ": " + val.errorMsg);
        //            }
        //        }
        //        while (true)
        //        {
        //            if (empType != 'c')
        //            {
        //                Console.WriteLine("Please Enter Date of Birth");
        //            }
        //            else
        //            {
        //                Console.WriteLine("Please Enter Company Start Date");
        //            }

        //            input = Console.ReadLine();
        //            if (val.date(input))
        //            {
        //                baseEmp.SetDOB(DateTime.ParseExact(input, "yyyy-mm-dd", CultureInfo.InvariantCulture, DateTimeStyles.None));
        //                break;
        //            }
        //            else
        //            {
        //                log.writeLog(input + ": " + val.errorMsg);
        //                Console.WriteLine(input + ": " + val.errorMsg);
        //            }
        //        }
        //        if (empType == 'f')
        //        {
        //            menuFourFT();
        //            break;
        //        }
        //        else if (empType == 'p')
        //        {
        //            menuFourPT();
        //            break;
        //        }
        //        else if (empType == 'c')
        //        {
        //            menuFourCT();
        //            break;
        //        }
        //        else if (empType == 's')
        //        {
        //            menuFourSN();
        //            break;
        //        }
        //    }
        //}
        //public void menuFourFT()
        //{
        //    DateTime tempTime = new DateTime();
        //    while (mainMenu != true)
        //    {
        //        Console.Clear();
        //        Console.WriteLine("Menu 4: Employee Details Menu");
        //        Console.WriteLine("1. Specify Base Employee");
        //        Console.WriteLine("2. Set Employee Date Of Hire");
        //        Console.WriteLine("3. Set Employee Date Of Termination");
        //        Console.WriteLine("4. Set Employee Salary");
        //        Console.WriteLine("9. Save and Return to Main Menu");

        //        choice = Console.ReadKey();
        //        if (choice.KeyChar == '1')
        //        {
        //            //create base employee
        //            createBase();
        //        }
        //        else if (choice.KeyChar == '2')
        //        {
        //            //set date of hire
        //            while (true)
        //            {
        //                Console.WriteLine("Please Enter date of hire (YYYY-MM-DD");
        //                input = Console.ReadLine();
        //                if (val.date(input))
        //                {
        //                    tempTime = DateTime.ParseExact(input, "yyyy-mm-dd", CultureInfo.InvariantCulture, DateTimeStyles.None);
        //                    if (tempTime > DateTime.Now)
        //                    {
        //                        log.writeLog(input + ": You can't have been hired before the current date");
        //                        Console.WriteLine(input + ": You can't have been hired before the current date");
        //                    }
        //                    else if (ft.GetDateOfTermination() != null && ft.GetDateOfTermination() < tempTime)
        //                    {
        //                        log.writeLog(input + ": You can't have been hired before you've been terminated");
        //                        Console.WriteLine(input + ": You can't have been hired before you've been terminated");
        //                    }
        //                    else
        //                    {
        //                        ft.SetDateOfHire(tempTime);
        //                        break;
        //                    }
        //                }
        //                else
        //                {
        //                    log.writeLog(input + ": " + val.errorMsg);
        //                    Console.WriteLine(input + ": " + val.errorMsg);
        //                }
        //            }
        //        }
        //        else if (choice.KeyChar == '3')
        //        {
        //            //set date of termination
        //            while (true)
        //            {
        //                Console.WriteLine("Please Enter date of termination (YYYY-MM-DD");
        //                input = Console.ReadLine();
        //                if (val.date(input))
        //                {
        //                    tempTime = DateTime.ParseExact(input, "yyyy-mm-dd", CultureInfo.InvariantCulture, DateTimeStyles.None);
        //                    if (tempTime > DateTime.Now)
        //                    {
        //                        log.writeLog(input + ": You can't have been terminated before the current date");
        //                        Console.WriteLine(input + ": You can't have been terminated before the current date");
        //                    }
        //                    else if (ft.GetDateOfHire() != null && ft.GetDateOfHire() > tempTime)
        //                    {
        //                        log.writeLog(input + ": You can't have been hired before you've been terminated");
        //                        Console.WriteLine(input + ": You can't have been hired before you've been terminated");
        //                    }
        //                    else
        //                    {
        //                        ft.SetDateOfTermination(tempTime);
        //                        break;
        //                    }
        //                }
        //                else
        //                {
        //                    log.writeLog(input + ": " + val.errorMsg);
        //                    Console.WriteLine(input + ": " + val.errorMsg);
        //                }
        //            }
        //        }
        //        else if (choice.KeyChar == '4')
        //        {
        //            //set employee salary
        //            while (true)
        //            {
        //                Console.WriteLine("Please enter salary");
        //                input = Console.ReadLine();
        //                if (val.rate(input))
        //                {
        //                    ft.SetSalary(Convert.ToDecimal(input));
        //                    break;
        //                }
        //                else
        //                {
        //                    log.writeLog(input + ": " + val.errorMsg);
        //                    Console.WriteLine(input + ": " + val.errorMsg);
        //                }
        //            }
        //        }
        //        else if (choice.KeyChar == '9')
        //        {
        //            mainMenu = true;
        //            while (true)
        //            {
        //                Console.WriteLine("Would you like to save? 'y' or 'n'");
        //                choice = Console.ReadKey();
        //                if (choice.KeyChar == 'y')
        //                {
        //                    company.AddFullTimeEmployee(ft);
        //                    break;
        //                }
        //                else if (choice.KeyChar == 'n')
        //                {
        //                    break;
        //                }
        //            }
        //            break;
        //        }
        //    }
        //}
        //public void menuFourPT()
        //{
        //    DateTime tempTime = new DateTime();
        //    while (mainMenu != true)
        //    {
        //        Console.Clear();
        //        Console.WriteLine("Menu 4: Employee Details Menu");
        //        Console.WriteLine("1. Specify Base Employee");
        //        Console.WriteLine("2. Set Employee Date Of Hire");
        //        Console.WriteLine("3. Set Employee Date Of Termination");
        //        Console.WriteLine("4. Set Employee Salary");
        //        Console.WriteLine("9. Save and Return to Main Menu");

        //        choice = Console.ReadKey();
        //        if (choice.KeyChar == '1')
        //        {
        //            createBase();
        //        }
        //        else if (choice.KeyChar == '2')
        //        {
        //            //set date of hire
        //            while (true)
        //            {
        //                Console.WriteLine("Please Enter date of hire (YYYY-MM-DD");
        //                input = Console.ReadLine();
        //                if (val.date(input))
        //                {
        //                    tempTime = DateTime.ParseExact(input, "yyyy-mm-dd", CultureInfo.InvariantCulture, DateTimeStyles.None);
        //                    if (tempTime > DateTime.Now)
        //                    {
        //                        log.writeLog(input + ": You can't have been hired before the current date");
        //                        Console.WriteLine(input + ": You can't have been hired before the current date");
        //                    }
        //                    else if (pt.GetDateOfTermination() != null && pt.GetDateOfTermination() < tempTime)
        //                    {
        //                        log.writeLog(input + ": You can't have been hired before you've been terminated");
        //                        Console.WriteLine(input + ": You can't have been hired before you've been terminated");
        //                    }
        //                    else
        //                    {
        //                        pt.SetDateOfHire(tempTime);
        //                        break;
        //                    }
        //                }
        //                else
        //                {
        //                    log.writeLog(input + ": " + val.errorMsg);
        //                    Console.WriteLine(input + ": " + val.errorMsg);
        //                }
        //            }
        //        }
        //        else if (choice.KeyChar == '3')
        //        {
        //            //set date of termination
        //            while (true)
        //            {
        //                Console.WriteLine("Please Enter date of termination (YYYY-MM-DD");
        //                input = Console.ReadLine();
        //                if (val.date(input))
        //                {
        //                    tempTime = DateTime.ParseExact(input, "yyyy-mm-dd", CultureInfo.InvariantCulture, DateTimeStyles.None);
        //                    if (tempTime > DateTime.Now)
        //                    {
        //                        log.writeLog(input + ": You can't have been terminated before the current date");
        //                        Console.WriteLine(input + ": You can't have been terminated before the current date");
        //                    }
        //                    else if (pt.GetDateOfHire() != null && pt.GetDateOfHire() > tempTime)
        //                    {
        //                        log.writeLog(input + ": You can't have been hired before you've been terminated");
        //                        Console.WriteLine(input + ": You can't have been hired before you've been terminated");
        //                    }
        //                    else
        //                    {
        //                        pt.SetDateOfTermination(tempTime);
        //                        break;
        //                    }
        //                }
        //                else
        //                {
        //                    log.writeLog(input + ": " + val.errorMsg);
        //                    Console.WriteLine(input + ": " + val.errorMsg);
        //                }
        //            }
        //        }
        //        else if (choice.KeyChar == '4')
        //        {
        //            //set employee salary
        //            while (true)
        //            {
        //                Console.WriteLine("Please enter salary");
        //                input = Console.ReadLine();
        //                if (val.rate(input))
        //                {
        //                    pt.SetHourlyRate(Convert.ToDecimal(input));
        //                    break;
        //                }
        //                else
        //                {
        //                    log.writeLog(input + ": " + val.errorMsg);
        //                    Console.WriteLine(input + ": " + val.errorMsg);
        //                }
        //            }
        //        }
        //        else if (choice.KeyChar == '9')
        //        {
        //            mainMenu = true;
        //            while (true)
        //            {
        //                Console.WriteLine("Would you like to save? 'y' or 'n'");
        //                choice = Console.ReadKey();
        //                if (choice.KeyChar == 'y')
        //                {
        //                    company.AddPartTimeEmployee(pt);
        //                    break;
        //                }
        //                else if (choice.KeyChar == 'n')
        //                {
        //                    break;
        //                }
        //            }
        //            break;
        //        }
        //    }
        //}
        //public void menuFourCT()
        //{
        //    DateTime tempTime = new DateTime();
        //    while (mainMenu != true)
        //    {
        //        Console.Clear();
        //        Console.WriteLine("Menu 4: Employee Details Menu");
        //        Console.WriteLine("1. Specify Base Employee");
        //        Console.WriteLine("2. Set Employee Contract Start Date");
        //        Console.WriteLine("3. Set Employee Contract Stop Date");
        //        Console.WriteLine("4. Set Employee Fixed Contract Amount");
        //        Console.WriteLine("9. Save and Return to Main Menu");

        //        choice = Console.ReadKey();
        //        if (choice.KeyChar == '1')
        //        {
        //            createBase();
        //        }
        //        else if (choice.KeyChar == '2')
        //        {
        //            //set contract start date
        //            while (true)
        //            {
        //                Console.WriteLine("Please Enter contract start date (YYYY-MM-DD");
        //                input = Console.ReadLine();
        //                if (val.date(input))
        //                {
        //                    tempTime = DateTime.ParseExact(input, "yyyy-mm-dd", CultureInfo.InvariantCulture, DateTimeStyles.None);
        //                    if (ct.dateOfTermination != null && ct.dateOfTermination < tempTime)
        //                    {
        //                        log.writeLog(input + ": You cant start a contract after it's been ended");
        //                        Console.WriteLine(input + ": You cant start a contract after it's been ended");
        //                    }
        //                    else
        //                    {
        //                        ct.SetContractStartDate(tempTime);
        //                        break;
        //                    }
        //                }
        //                else
        //                {
        //                    log.writeLog(input + ": " + val.errorMsg);
        //                    Console.WriteLine(input + ": " + val.errorMsg);
        //                }
        //            }
        //        }
        //        else if (choice.KeyChar == '3')
        //        {
        //            //set date of termination
        //            while (true)
        //            {
        //                Console.WriteLine("Please Enter Contract end date (YYYY-MM-DD");
        //                input = Console.ReadLine();
        //                if (val.date(input))
        //                {
        //                    tempTime = DateTime.ParseExact(input, "yyyy-mm-dd", CultureInfo.InvariantCulture, DateTimeStyles.None);
        //                    if (ct.contractStartDate != null && ct.contractStartDate > tempTime)
        //                    {
        //                        log.writeLog(input + ": You cant end a contract before its begun");
        //                        Console.WriteLine(input + ": You cant end a contract before its begun");
        //                    }
        //                    else
        //                    {
        //                        ct.SetDateOfTermination(tempTime);
        //                        break;
        //                    }
        //                }
        //                else
        //                {
        //                    log.writeLog(input + ": " + val.errorMsg);
        //                    Console.WriteLine(input + ": " + val.errorMsg);
        //                }
        //            }
        //        }
        //        else if (choice.KeyChar == '4')
        //        {
        //            //set contract salary
        //            while (true)
        //            {
        //                Console.WriteLine("Please enter hourly rate");
        //                input = Console.ReadLine();
        //                if (val.rate(input))
        //                {
        //                    ct.SetHourlyRate(input);
        //                    break;
        //                }
        //                else
        //                {
        //                    log.writeLog(input + ": " + val.errorMsg);
        //                    Console.WriteLine(input + ": " + val.errorMsg);
        //                }
        //            }
        //        }
        //        else if (choice.KeyChar == '9')
        //        {
        //            mainMenu = true;
        //            while (true)
        //            {
        //                Console.WriteLine("Would you like to save? 'y' or 'n'");
        //                choice = Console.ReadKey();
        //                if (choice.KeyChar == 'y')
        //                {
        //                    company.AddContractEmployee(ct);
        //                    break;
        //                }
        //                else if (choice.KeyChar == 'n')
        //                {
        //                    break;
        //                }
        //            }
        //            break;
        //        }
        //    }
        //}
        //public void menuFourSN()
        //{
        //    DateTime tempTime = new DateTime();
        //    while (mainMenu != true)
        //    {
        //        Console.Clear();
        //        Console.WriteLine("Menu 4: Employee Details Menu");
        //        Console.WriteLine("1. Specify Base Employee");
        //        Console.WriteLine("2. Set Season of Work Period");
        //        Console.WriteLine("3. Set Piece Pay Salary");
        //        Console.WriteLine("9. Save and Return to Main Menu");

        //        choice = Console.ReadKey();
        //        if (choice.KeyChar == '1')
        //        {
        //            createBase();
        //        }
        //        else if (choice.KeyChar == '2')
        //        {
        //            //set season
        //            while (true)
        //            {
        //                Console.WriteLine("Please Enter season of work");
        //                input = Console.ReadLine();
        //                input = input.ToLower();
        //                input = input.Trim();
        //                if (input == "summer" || input == "winter" || input == "fall" || input == "spring")
        //                {
        //                    sn.SetSeason(input);
        //                    break;
        //                }
        //                else
        //                {
        //                    log.writeLog(input + ": seasons can be summer, winter, fall, or spring");
        //                    Console.WriteLine(input + ": seasons can be summer, winter, fall, or spring");
        //                }
        //            }
        //        }
        //        else if (choice.KeyChar == '3')
        //        {
        //            //set employee salary
        //            while (true)
        //            {
        //                Console.WriteLine("Please enter Peicepay");
        //                input = Console.ReadLine();
        //                if (val.rate(input))
        //                {
        //                    ct.SetHourlyRate(input); //TODO change contract to use a string instead of double
        //                    break;
        //                }
        //                else
        //                {
        //                    log.writeLog(input + ": " + val.errorMsg);
        //                    Console.WriteLine(input + ": " + val.errorMsg);
        //                }
        //            }
        //        }
        //        else if (choice.KeyChar == '9')
        //        {
        //            mainMenu = true;
        //            while (true)
        //            {
        //                Console.WriteLine("Would you like to save? 'y' or 'n'");
        //                choice = Console.ReadKey();
        //                if (choice.KeyChar == 'y')
        //                {
        //                    company.AddSeasonalEmployee(sn);
        //                    break;
        //                }
        //                else if (choice.KeyChar == 'n')
        //                {
        //                    break;
        //                }
        //            }
        //            break;
        //        }
        //    }
        //}
#endregion
    }
}

