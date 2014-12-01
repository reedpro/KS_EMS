//
// FILE: UnitTest_Employee.cs
// PROJ: INFO2180-14F - Milestone 5 - Test Plan
// NAME: Kivetsu Solutions - Jay, Jordan, Thom, Rachel
// 1stV: 11-28-2014
// DESC: File contains unit test methods for the methods in the Employee class
//
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AllEmployees;
using Supporting;
///
/// <para>Test Identification</para>
/// <b>[LibraryName].[ClassName].[MethodName].[Normal, Boundary, Exception].[TestNumber]</b> 
/// <=> AE.E.[ ].[N, B, E].*
///

namespace UnitTest_AllEmployees
{
    [TestClass]
    public class UnitTest_Employee
    {
        ///
        /// <para><b>Test Identifier</b> - SetSIN_NormalTest1()</para>
        /// <para><b>Unique Identifier</b> - AE.E.SDH.N.1</para>
        /// <para><b>Description</b> - Method tests the regular use of the method, attempting to set SIN number of the Employee object</para>
        /// <para><b>Method of execution</b> - Automatic</para>
        /// <para><b>Input data</b> - "123456789"</para>
        /// <para><b>Expected outputs</b> - "123456789" set correctly for SIN of that employee</para>
        /// <para><b>Observed outputs</b> - TO DO at project completion</para>
        /// <para><b>If Failed</b> - Displays failed message regarding setting the variable</para>
        /// 
        [TestMethod]
        public void SetSIN_NormalTest1()
        {

        }

        ///
        /// <para><b>Test Identifier</b> - SetDateOfTermination_NormalTest1()</para>
        /// <para><b>Unique Identifier</b> - AE.E.SFN.N.1</para>
        /// <para><b>Description</b> - Method tests the regular use of the method, attempting to set the FirstName variable</para>
        /// <para><b>Method of execution</b> - Automatic</para>
        /// <para><b>Input data</b> - "Jade"</para>
        /// <para><b>Expected outputs</b> - "Jade" set correctly for variable: FirstName</para>
        /// <para><b>Observed outputs</b> - TO DO at project completion</para>
        /// <para><b>If Failed</b> - FirstName variable is not set properly, and no logging for that</para>
        ///
        [TestMethod]
        public void SetFirstName_NormalTest1()
        {

        }

        ///
        /// <para><b>Test Identifier</b> - SetDateOfTermination_ExceptionTest1()</para>
        /// <para><b>Unique Identifier</b> - AE.E.SFN.E.1</para>
        /// <para><b>Description</b> - Method tests the exceptional use of the method, attempting to set the FirstName variable with invalid format of string</para>
        /// <para><b>Method of execution</b> - Automatic</para>
        /// <para><b>Input data</b> - "제이슨 므라즈"</para>
        /// <para><b>Expected outputs</b> -Throwing excpetion to notify the fact that invalid data is passed in and the failed attempt logged</para>
        /// <para><b>Observed outputs</b> - TO DO at project completion</para>
        /// <para><b>If Failed</b> - corrupt data is used to set FirstName variable and/or no logging activity</para>
        ///
        [TestMethod]
        public void SetFirstName_ExceptionTest1()
        {

        }
        ///
        /// <para><b>Test Identifier</b> - SetSalary_ExceptionTest1()</para>
        /// <para><b>Unique Identifier</b> - AE.E.SS.E.1</para>
        /// <para><b>Description</b> - Method tests exceptional use of the method, attempting to set the Salary variable to illegal data type</para>
        /// <para><b>Method of execution</b> - Automatic</para>
        /// <para><b>Input data</b> - -10.00</para>
        /// <para><b>Expected outputs</b> - -10.00 rejected as input</para>
        /// <para><b>Observed outputs</b> - TO DO at project completion</para>
        /// <para><b>If Failed</b> - No Displays failed message regarding setting the variable and/or logging activity</para>
        ///
        [TestMethod]
        public void SetSalary_ExceptionTest1()
        {

        }

    }
}
