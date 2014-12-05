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
using System.Threading.Tasks;
using System.Globalization;
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
        string dBaseFile;
        FileIO fileClass = new FileIO();
        Container company = new Container();
        Validation val = new Validation();
        Logging log = new Logging();
        ContractEmployee ct = new ContractEmployee();
        FulltimeEmployee ft = new FulltimeEmployee();
        SeasonalEmployee sn = new SeasonalEmployee();
        ParttimeEmployee pt = new ParttimeEmployee();
        Employee baseEmp = new Employee();
        bool mainMenu = false;
        char empType = 'x';
        string input = "";


        ///<summary>
        ///Method:MenuOne
        ///Purpose:The MenuOne meathod will display the first menu
        ///the user will be interacting with
        ///Depending on the users choice a diffrent menu will be called apon
        ///Inputs:None
        ///Returns:Void
        ///</summary>
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
                Console.WriteLine("3.Quit");

                choice = Console.ReadKey();
                if (choice.KeyChar == '1')
                {
                    MenuTwo();
                }

                if (choice.KeyChar == '2')
                {
                    MenuThree();
                }

                if (choice.KeyChar == '3')
                {
                    ///TO DO:
                    ///Save and exit Program
                    break;
                }
            }

        }



        ///<summary>
        ///Method:MenuTwo
        ///Purpose:The MenuTwo Meathod will display the Second 
        ///menu the user will interact with
        ///This Menu will Allow the User to either Save Or 
        ///Load a pre-existing DataBase
        ///Inputs:None
        ///Returns:Void
        ///</summary>
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
                    company.LoadContainer(dBaseFile);
                    ///Display File
                }

                if (choice.KeyChar == '2')
                {

                    ///Call to WriteFile()
                    company.SaveContainer(dBaseFile);
                }

                if (choice.KeyChar == '9')
                {
                    break;
                }
            }

        }

        ///<summary>
        ///Method:MenuThree
        ///Purpose:The MenuThree Meathod will display the third 
        ///menu the user will interact with
        ///This Menu will allow the user to Manage Employees
        ///either creating,viewing or Deleting
        ///Inputs:None
        ///Returns:Void
        ///</summary>
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
                if (choice.KeyChar == 1)
                {
                    ///TO DO:
                    ///Call Employee Set()
                    ///Traverse Employees
                    ///CAll Details()
                }


                if (choice.KeyChar == '2')
                {
                    manType = "Create";
                    MenuFour(manType);
                }

                if (choice.KeyChar == '3')
                {
                    manType = "Remove";
                    MenuFour(manType);
                }

                if (choice.KeyChar == '4')
                {

                    Console.WriteLine("Are You Sure You Would Like To Remove Employee?");
                    Console.WriteLine("Enter 1 for YES.");
                    Console.WriteLine("Enter 2 for NO.");


                    if (choice.KeyChar == '1')
                    {
                        ///TO DO Call RemoveEmployee()
                        Console.WriteLine("Employee Removed Successfully.");
                        MenuThree();
                    }
                    if (choice.KeyChar == '2')
                    {
                        Console.WriteLine("Employee Was NOT Removed");
                        MenuThree();
                    }


                }

                if (choice.KeyChar == '9')
                {
                    break;
                }
            }
        }

        ///<summary>
        ///Method:MenuFour
        ///Purpose:The MenuFour Meathod will display the forth
        ///menu the user will interact with
        ///This Menu will Allow a user to Delete an existing Employee
        ///Or Create a new one. If creating an Employee the user will
        ///be prompted Appropriatly for the type of Employee being added
        ///Inputs:String,ManType
        ///Return:Void
        ///</summary>
        ///<param name="ManType">This paramater is either Create Or Delete Specifying if the user 
        ///wishes to create or delte an Employee</param>
        public void MenuFour(String ManType)
        {
            while (mainMenu != true)
            {
                if (ManType == "Remove")
                {
                    ///TO DO: Call REMOVE();
                }

                    ///Menu 4
                else if (ManType == "Create")
                {
                    Console.Clear();
                    Console.WriteLine("Menu 4: Employee Details Menu");
                    Console.WriteLine("1. Specify Base Employee");
                    Console.WriteLine("9. Return to Main Menu");

                    choice = Console.ReadKey();
                    if (choice.KeyChar == '1')
                    {
                        createBase();            
                    }

                    if (choice.KeyChar == '9')
                    {
                        break;
                    }
                }
            }
        }

        public void createBase()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Please Enter Employee Type ");
                Console.WriteLine("1. Full Time");
                Console.WriteLine("2. Part Tme");
                Console.WriteLine("3. Contract");
                Console.WriteLine("4. Seasonal");
                Console.WriteLine("9. Quit");
                choice = Console.ReadKey();
                if (choice.KeyChar == '1')
                {
                    empType = 'f';
                }
                else if (choice.KeyChar == '2')
                {
                    empType = 'p';
                }
                else if (choice.KeyChar == '3')
                {
                    empType = 'c';
                }
                else if (choice.KeyChar == '4')
                {
                    empType = 's';
                }
                else if (choice.KeyChar == '9')
                {
                    break;
                }

                Console.Clear();
                while (true)
                {
                    if (empType != 'c')
                    {
                        Console.WriteLine("Please Enter Last Name:");
                    }
                    else
                    {
                        Console.WriteLine("please Enter Company Name:");
                    }
                    input = Console.ReadLine();
                    if (val.name(input))
                    {
                        baseEmp.SetLastName(input);
                        break;
                    }
                    else
                    {
                        log.writeLog(input + ": " + val.errorMsg);
                        Console.WriteLine(input + ": " + val.errorMsg);
                    }
                }
                if (empType != 'c')
                {
                    while (true)
                    {
                        Console.WriteLine("Please Enter First name:");
                        input = Console.ReadLine();
                        if (val.name(input))
                        {
                            baseEmp.SetFirstName(input);
                            break;
                        }
                        else
                        {
                            log.writeLog(input + ": " + val.errorMsg);
                            Console.WriteLine(input + ": " + val.errorMsg);
                        }
                    }
                }
                while (true)
                {
                    if (empType != 'c')
                    {
                        Console.WriteLine("Plese Enter SIN");
                    }
                    else
                    {
                        Console.WriteLine("Plese Enter BIN");
                    }
                    input = Console.ReadLine();
                    if (val.sin(input))
                    {
                        baseEmp.SetSIN(input);
                        break;
                    }
                    else
                    {
                        log.writeLog(input + ": " + val.errorMsg);
                        Console.WriteLine(input + ": " + val.errorMsg);
                    }
                }
                while (true)
                {
                    if (empType != 'c')
                    {
                        Console.WriteLine("Please Enter Date of Birth");
                    }
                    else
                    {
                        Console.WriteLine("Please Enter Company Start Date");
                    }

                    input = Console.ReadLine();
                    if (val.date(input))
                    {
                        baseEmp.SetDOB(DateTime.ParseExact(input, "yyyy-mm-dd", CultureInfo.InvariantCulture, DateTimeStyles.None));
                        break;
                    }
                    else
                    {
                        log.writeLog(input + ": " + val.errorMsg);
                        Console.WriteLine(input + ": " + val.errorMsg);
                    }
                }
                if (empType == 'f')
                {
                    menuFourFT();
                    break;
                }
                else if (empType == 'p')
                {
                    menuFourPT();
                    break;
                }
                else if (empType == 'c')
                {
                    menuFourCT();
                    break;
                }
                else if (empType == 's')
                {
                    menuFourSN();
                    break;
                }
            }
        }

        /// <summary>
        /// Menu 4 for fulltime employee
        /// </summary>
        public void menuFourFT()
        {
            DateTime tempTime = new DateTime();
            while(mainMenu != true)
            {
                Console.Clear();
                Console.WriteLine("Menu 4: Employee Details Menu");
                Console.WriteLine("1. Specify Base Employee");
                Console.WriteLine("2. Set Employee Date Of Hire");
                Console.WriteLine("3. Set Employee Date Of Termination");
                Console.WriteLine("4. Set Employee Salary");
                Console.WriteLine("9. Save and Return to Main Menu");

                choice = Console.ReadKey();
                if (choice.KeyChar == '1')
                {
                    //create base employee
                    createBase();
                }
                else if(choice.KeyChar == '2')
                {
                    //set date of hire
                    while (true)
                    {
                        Console.WriteLine("Please Enter date of hire (YYYY-MM-DD");
                        input = Console.ReadLine();
                        if (val.date(input))
                        {               
                            tempTime = DateTime.ParseExact(input, "yyyy-mm-dd", CultureInfo.InvariantCulture, DateTimeStyles.None);
                            if (tempTime > DateTime.Now)
                            {
                                log.writeLog(input + ": You can't have been hired before the current date");
                                Console.WriteLine(input + ": You can't have been hired before the current date");
                            }
                            else if (ft.dateOfTermination != null && ft.dateOfTermination < tempTime)
                            {
                                log.writeLog(input + ": You can't have been hired before you've been terminated");
                                Console.WriteLine(input + ": You can't have been hired before you've been terminated");
                            }
                            else
                            {
                                ft.SetDateOfHire(tempTime);
                                break;
                            }
                        }
                        else
                        {
                            log.writeLog(input + ": " + val.errorMsg);
                            Console.WriteLine(input + ": " + val.errorMsg);
                        }
                    }
                }
                else if (choice.KeyChar == '3')
                {
                    //set date of termination
                    while (true)
                    {
                        Console.WriteLine("Please Enter date of termination (YYYY-MM-DD");
                        input = Console.ReadLine();
                        if (val.date(input))
                        {
                            tempTime = DateTime.ParseExact(input, "yyyy-mm-dd", CultureInfo.InvariantCulture, DateTimeStyles.None);
                            if (tempTime > DateTime.Now)
                            {
                                log.writeLog(input + ": You can't have been terminated before the current date");
                                Console.WriteLine(input + ": You can't have been terminated before the current date");
                            }
                            else if (ft.dateOfHire != null && ft.dateOfHire > tempTime)
                            {
                                log.writeLog(input + ": You can't have been hired before you've been terminated");
                                Console.WriteLine(input + ": You can't have been hired before you've been terminated");
                            }
                            else
                            {
                                ft.SetDateOfTermination(tempTime);
                                break;
                            }
                        }
                        else
                        {
                            log.writeLog(input + ": " + val.errorMsg);
                            Console.WriteLine(input + ": " + val.errorMsg);
                        }
                    }
                }
                else if(choice.KeyChar == '4')
                {
                    //set employee salary
                    while(true)
                    {
                        Console.WriteLine("Please enter salary");
                        input = Console.ReadLine();
                        if(val.rate(input))
                        {
                            ft.SetSalary(input);
                            break;
                        }
                        else
                        {
                            log.writeLog(input + ": " + val.errorMsg);
                            Console.WriteLine(input + ": " + val.errorMsg);
                        }
                    }
                }
                else if(choice.KeyChar == '9')
                {
                    break;
                }
            }
        }
        /// <summary>
        /// menu 4 for part time
        /// </summary>
        public void menuFourPT()
        {
            DateTime tempTime = new DateTime();
            while (mainMenu != true)
            {
                Console.Clear();
                Console.WriteLine("Menu 4: Employee Details Menu");
                Console.WriteLine("1. Specify Base Employee");
                Console.WriteLine("2. Set Employee Date Of Hire");
                Console.WriteLine("3. Set Employee Date Of Termination");
                Console.WriteLine("4. Set Employee Salary");
                Console.WriteLine("9. Save and Return to Main Menu");

                choice = Console.ReadKey();
                if (choice.KeyChar == '1')
                {
                    createBase();
                }
                else if (choice.KeyChar == '2')
                {
                    //set date of hire
                    while (true)
                    {
                        Console.WriteLine("Please Enter date of hire (YYYY-MM-DD");
                        input = Console.ReadLine();
                        if (val.date(input))
                        {
                            tempTime = DateTime.ParseExact(input, "yyyy-mm-dd", CultureInfo.InvariantCulture, DateTimeStyles.None);
                            if (tempTime > DateTime.Now)
                            {
                                log.writeLog(input + ": You can't have been hired before the current date");
                                Console.WriteLine(input + ": You can't have been hired before the current date");
                            }
                            else if (pt.dateOfTermination != null && pt.dateOfTermination < tempTime)
                            {
                                log.writeLog(input + ": You can't have been hired before you've been terminated");
                                Console.WriteLine(input + ": You can't have been hired before you've been terminated");
                            }
                            else
                            {
                                pt.SetDateOfHire(tempTime);
                                break;
                            }
                        }
                        else
                        {
                            log.writeLog(input + ": " + val.errorMsg);
                            Console.WriteLine(input + ": " + val.errorMsg);
                        }
                    }
                }
                else if (choice.KeyChar == '3')
                {
                    //set date of termination
                    while (true)
                    {
                        Console.WriteLine("Please Enter date of termination (YYYY-MM-DD");
                        input = Console.ReadLine();
                        if (val.date(input))
                        {
                            tempTime = DateTime.ParseExact(input, "yyyy-mm-dd", CultureInfo.InvariantCulture, DateTimeStyles.None);
                            if (tempTime > DateTime.Now)
                            {
                                log.writeLog(input + ": You can't have been terminated before the current date");
                                Console.WriteLine(input + ": You can't have been terminated before the current date");
                            }
                            else if (pt.dateOfHire != null && pt.dateOfHire > tempTime)
                            {
                                log.writeLog(input + ": You can't have been hired before you've been terminated");
                                Console.WriteLine(input + ": You can't have been hired before you've been terminated");
                            }
                            else
                            {
                                pt.SetDateOfTermination(tempTime);
                                break;
                            }
                        }
                        else
                        {
                            log.writeLog(input + ": " + val.errorMsg);
                            Console.WriteLine(input + ": " + val.errorMsg);
                        }
                    }
                }
                else if (choice.KeyChar == '4')
                {
                    //set employee salary
                    while (true)
                    {
                        Console.WriteLine("Please enter salary");
                        input = Console.ReadLine();
                        if (val.rate(input))
                        {
                            pt.SetHourlyRate(input);
                            break;
                        }
                        else
                        {
                            log.writeLog(input + ": " + val.errorMsg);
                            Console.WriteLine(input + ": " + val.errorMsg);
                        }
                    }
                }
                else if(choice.KeyChar == '9')
                {
                    mainMenu = true;
                    break;
                }
            }
        }
        /// <summary>
        /// menu 4 for contract
        /// </summary>
        public void menuFourCT()
        {

            while (mainMenu != true)
            {
                Console.Clear();
                Console.WriteLine("Menu 4: Employee Details Menu");
                Console.WriteLine("1. Specify Base Employee");
                Console.WriteLine("2. Set Employee Contract Start Date");
                Console.WriteLine("3. Set Employee Contract Stop Date");
                Console.WriteLine("4. Set Employee Fixed Contract Amount");
                Console.WriteLine("9. Save and Return to Main Menu");

                choice = Console.ReadKey();
                if (choice.KeyChar == '1')
                {
                    createBase();
                }
                else if (choice.KeyChar == '9')
                {
                    mainMenu = true;
                    break;
                }
            }
        }
        /// <summary>
        /// menu 4 for seasonal
        /// </summary>
        public void menuFourSN()
        {
            while (mainMenu != true)
            {
                Console.Clear();
                Console.WriteLine("Menu 4: Employee Details Menu");
                Console.WriteLine("1. Specify Base Employee");
                Console.WriteLine("2. Set Season of Work Period");
                Console.WriteLine("3. Set Piece Pay Salary");
                Console.WriteLine("9. Save and Return to Main Menu");

                choice = Console.ReadKey();
                if (choice.KeyChar == '1')
                {
                    createBase();
                }
                else if (choice.KeyChar == '9')
                {
                    mainMenu = true;
                    break;
                }
            }
        }
    }
}

