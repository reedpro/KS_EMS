//
// FILE: UnitTest_UIMenu.cs
// PROJ: INFO2180-14F - Milestone 5 - Test Plan
// NAME: Kivetsu Solutions - Jay, Jordan, Thom, Rachel
// 1stV: 11-28-2014
// DESC: File contains unit test methods for the methods in the FullTimeEmployee class
//
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AllEmployees;
using Supporting;
using Presentation;

///
/// <para>Test Identification</para>
/// <b>[LibraryName].[ClassName].[MethodName].[Normal, Boundary, Exception].[TestNumber]</b> 
/// <=> P.UI.[ ].[N, B, E].*
///

namespace UnitTest_UIMenu
{
    [TestClass]
    public class UnitTest_UIMenu
    {
        ///
        /// <para><b>Test Identifier</b> - MenuOne-Normal Tests()</para>
        /// <para><b>Unique Identifier</b> - P.UI.MO.N.1</para>
        /// <para><b>Description</b> - Ensure each menu option can be accessed. Each menu option will be selected to make sure it leads to the corresponding menu.</para>
        /// <para><b>Method of execution</b> - These test will be entered manually, by entering each number in the menu list, and checking the outcome. </para>
        /// <para><b>Input data</b> - "1,2,3"</para>
        /// <para><b>Expected outputs</b> - "1 entered should bring the user too menu two.</para>  
        /// <para><b>2 entered should bring the user to menu three.</para>
        /// <para><b>3 entered should quit the program. Saving the current state of the database.</para> 
        /// <para><b>Observed outputs</b> - TBD</para>
        /// <para><b>If Failed</b> - Displays failed message regarding use of menu one</para>
        /// 

        ///
        /// <para><b>Test Identifier</b> - MenuOne- Exception Test()</para>
        /// <para><b>Unique Identifier</b> - P.UI.MO.E.1</para>
        /// <para><b>Description</b> - This set of tests will ensure that if the user enters an incorrect number into the main menu, an appropriate error message will be shown to the user.</para>
        /// <para><b>Method of execution</b> - These test will be entered manually, by entering each number in the menu list, and checking the outcome.  </para>
        /// <para><b>Input data</b> - "4,5,6, A,B,C,!,@,#"</para>
        /// <para><b>Expected outputs</b> - "All inputs should generate an error message to user stating use of menu".</para> 
        /// <para><b>Observed outputs</b> - TBD</para>
        /// <para><b>If Failed</b> - "Invalid data will be passed through"</para>
        /// 

        ///
        /// <para><b>Test Identifier</b> - MenuTwo-Normal Test</para>
        /// <para><b>Unique Identifier</b> - P.UI.MT.N.1</para>
        /// <para><b>Description</b> - This set of tests will ensure each menu option can be accessed. Each menu option will be selected to make sure it leads to the corresponding menu.</para>
        /// <para><b>Method of execution</b> - These test will be entered manually, by entering each number in the menu list, and checking the outcome.  </para>
        /// <para><b>Input data</b> - "1,2,9"</para>
        /// <para><b>Expected outputs</b> - "1 Entered will load a pre-saved database from a file.</para> 
        /// <para>2 Entered will save employee set to a database file</para>
        /// <para>9 Entered will return the user to the main menu</para> 
        /// <para><b>Observed outputs</b> - TBD</para>
        /// <para><b>If Failed</b> - "Displays failed Error message regarding use of menu one"</para>
        ///


        ///
        /// <para><b>Test Identifier</b> - MenuTwo- Exception Test</para>
        /// <para><b>Unique Identifier</b> - P.UI.MT.E.1</para>
        /// <para><b>Description</b> - This set of tests will ensure that if the user enters an incorrect number into the main menu, an appropriate error message will be shown to the user.</para>
        /// <para><b>Method of execution</b> - These test will be entered manually, by entering each number in the menu list, and checking the outcome.  </para>
        /// <para><b>Input data</b> - "4,5,6, A,B,C,!,@,#"</para>
        /// <para><b>Expected outputs</b> - "All inputs should generate an error message to user stating use of menu"</para> 
        /// <para><b>Observed outputs</b> - TBD</para>
        /// <para><b>If Failed</b> - "Invalid data will be passed through"</para>
        ///


        ///
        /// <para><b>Test Identifier</b> - MenuThree-normal Tests</para>
        /// <para><b>Unique Identifier</b> - P.UI.M3.N.1</para>
        /// <para><b>Description</b> - This set of tests will ensure each menu option can be accessed. Each menu option will be selected to make sure it leads to the corresponding menu. </para>
        /// <para><b>Method of execution</b> - These test will be entered manually, by entering each number in the menu list, and checking the outcome.  </para>
        /// <para><b>Input data</b> - "1, 2, 3, 4, 9"</para>
        /// <para><b>Expected outputs</b> - "1 entered will allow user to select an employee set, The selected set will then be displayed to the user</para>
        /// <para>2 Entered Will Take the user to menu 4. From menu 4 they will be able to enter a new employee</para>
        /// <para>3 Entered will take the user to Menu 4 so they will be able to modify an existing employee</para>
        /// <para>4 User will be prompted with an “Are you sure you wish to remove employee” message</para>
        /// <para>If user enters 1 the employee will be removed. If user enters 2 the employee will not be removed.</para> 
        /// <para><b>Observed outputs</b> - TBD</para>
        /// <para><b>If Failed</b> - "Displays failed Error message regarding use of menu three"</para>
        ///

        ///
        /// <para><b>Test Identifier</b> - Menu Three- Exception Test</para>
        /// <para><b>Unique Identifier</b> - P.UI.M3.E.1</para>
        /// <para><b>Description</b> - This set of tests will ensure that if the user enters an incorrect number into the menu, an appropriate error message will be shown to the user.</para>
        /// <para><b>Method of execution</b> - These test will be entered manually, by entering each number in the menu list, and checking the outcome.  </para>
        /// <para><b>Input data</b> - "7, 5, 6, A,B,C,!,@,#"</para>
        /// <para><b>Expected outputs</b> - "All inputs should generate an error message to user stating use of menu"</para> 
        /// <para><b>Observed outputs</b> - TBD</para>
        /// <para><b>If Failed</b> - "Invalid data will be passed through"</para>
        ///

        ///
        /// <para><b>Test Identifier</b> - MenuFour Normal Test</para>
        /// <para><b>Unique Identifier</b> - P.UI.MF.N.1</para>
        /// <para><b>Description</b> - This set of tests will ensure each menu option can be accessed. Each menu option will be selected to make sure it leads to the corresponding menu.  </para>
        /// <para><b>Method of execution</b> - These test will be entered manually, by entering each number in the menu list, and checking the outcome.  </para>
        /// <para><b>Input data</b> - "1, 2, 3, 4, 5, 9"</para>
        /// <para><b>Expected outputs</b> - "1 Entered Base employee is selected for new entry</para>
        /// <para> 2 Entered Full Time Employee is selected for new entry</para> 
        /// <para> 3 Entered Part Time Employee is selected for new entry</para>
        /// <para> 4 entered Contract employee is selected for new entry</para>
        /// <para> 5 entered Seasonal Employee is selected for new entry</para>
        /// <para> 9 Entered returns to main menu</para>
        ///<para> *After 12345 cases have been entered user will be prompted to enter each field the class contains. Other automated testing will ensure that these fields only accept the correct input.</para> 
        /// <para><b>Observed outputs</b> - TBD</para>
        /// <para><b>If Failed</b> - "Displays failed Error message regarding use of menu three"</para>
        ///

        ///
        /// <para><b>Test Identifier</b> - Menu Four- Exception Test</para>
        /// <para><b>Unique Identifier</b> - P.UI.MF.E.1</para>
        /// <para><b>Description</b> - This set of tests will ensure that if the user enters an incorrect number into the menu, an appropriate error message will be shown to the user.</para>
        /// <para><b>Method of execution</b> - These test will be entered manually, by entering each number in the menu list, and checking the outcome.  </para>
        /// <para><b>Input data</b> - "7, 8, 6, A,B,C,!,@,#"</para>
        /// <para><b>Expected outputs</b> - "All inputs should generate an error message to user stating use of menu"</para> 
        /// <para><b>Observed outputs</b> - TBD</para>
        /// <para><b>If Failed</b> - "Invalid data will be passed through"</para>
        ///


    }
}


