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
        /// <para><b>Unique Identifier</b> - AE.E.SS.N.1</para>
        /// <para><b>Description</b> - Method tests the regular use of the method, attempting to set SIN number of the Employee object</para>
        /// <para><b>Method of execution</b> - Automatic</para>
        /// <para><b>Input data</b> - "193 456 787"</para>
        /// <para><b>Expected outputs</b> - "193 456 787" set correctly for SIN of that employee</para>
        /// <para><b>Observed outputs</b> -Test Passed</para>
        /// <para><b>If Failed</b> - Displays failed message regarding setting the variable</para>
        /// 
        [TestMethod]
        public void SetSIN_NormalTest1()
        {
            Employee val = new Employee();
            string input = "193 456 787";
            bool expected = true;
            bool actual = false;

            actual = val.SetSIN(input);

            Assert.AreEqual(expected, actual, "Did not accept valid sin");
        }

        ///
        /// <para><b>Test Identifier</b> - SetFirstName_NormalTest1()</para>
        /// <para><b>Unique Identifier</b> - AE.E.SFN.N.1</para>
        /// <para><b>Description</b> - Method tests the regular use of the method, attempting to set the FirstName variable</para>
        /// <para><b>Method of execution</b> - Automatic</para>
        /// <para><b>Input data</b> - "Frank"</para>
        /// <para><b>Expected outputs</b> - "Frank" set correctly for variable: FirstName</para>
        /// <para><b>Observed outputs</b> - Test passed</para>
        /// <para><b>If Failed</b> - FirstName variable is not set properly, and no logging for that</para>
        ///
        [TestMethod]
        public void SetFirstName_NormalTest1()
        {
            Employee val = new Employee();
            string input = "Frank";
            bool expected = true;
            bool actual = false;

            actual = val.SetFirstName(input);

            Assert.AreEqual(expected, actual, "Did not accept valid First name");

        }

        ///
        /// <para><b>Test Identifier</b> - SetLastName_NormalTest1()</para>
        /// <para><b>Unique Identifier</b> - AE.E.SLN.N.1</para>
        /// <para><b>Description</b> - Method tests the regular use of the method, attempting to set the LastName variable</para>
        /// <para><b>Method of execution</b> - Automatic</para>
        /// <para><b>Input data</b> - "Taylor"</para>
        /// <para><b>Expected outputs</b> - "Taylor" set correctly for variable: FirstName</para>
        /// <para><b>Observed outputs</b> - Test passed</para>
        /// <para><b>If Failed</b> - FirstName variable is not set properly, and no logging for that</para>
        ///
        [TestMethod]
        public void SetLastName_NormalTest1()
        {
            Employee val = new Employee();
            string input = "Taylor";
            bool expected = true;
            bool actual = false;

            actual = val.SetLastName(input);

            Assert.AreEqual(expected, actual, "Did not accept valid First name");

        }

        ///
        /// <para><b>Test Identifier</b> - SetFirstName_ExceptionTest1()</para>
        /// <para><b>Unique Identifier</b> - AE.E.SFN.E.1</para>
        /// <para><b>Description</b> - Method tests the exceptional use of the method, attempting to set the FirstName variable with invalid format of string</para>
        /// <para><b>Method of execution</b> - Automatic</para>
        /// <para><b>Input data</b> - "제이슨 므라즈"</para>
        /// <para><b>Expected outputs</b> -Throwing excpetion to notify the fact that invalid data is passed in and the failed attempt logged</para>
        /// <para><b>Observed outputs</b> - Test Passed Invalid data rejected</para>
        /// <para><b>If Failed</b> - corrupt data is used to set FirstName variable and/or no logging activity</para>
        ///
        [TestMethod]
        public void SetFirstName_ExceptionTest1()
        {
            Employee val = new Employee();
            string input = "제이슨 므라즈";
            bool expected = false;
            bool actual = true;

            actual = val.SetFirstName(input);

            Assert.AreEqual(expected, actual, "Accepted false name");
        }
        ///
        /// <para><b>Test Identifier</b> - SetSIN_ExceptionTest1()</para>
        /// <para><b>Unique Identifier</b> - AE.E.SS.E.1</para>
        /// <para><b>Description</b> - Method tests exceptional use of the method, attempting to set the SIN variable to illegal data type</para>
        /// <para><b>Method of execution</b> - Automatic</para>
        /// <para><b>Input data</b> - 173 158 658</para>
        /// <para><b>Expected outputs</b> - 173 158 658</para>
        /// <para><b>Observed outputs</b> - Test Passed</para>
        /// <para><b>If Failed</b> -Error message stating variable handling</para>
        ///
        [TestMethod]
        public void SetSIN_ExceptionTest1()
        {
            Employee val = new Employee();
            string input = "123 456 789";
            bool expected = false;
            bool actual = true;

            actual = val.SetSIN(input);

            Assert.AreEqual(expected, actual, "Accepted inproper SIN");
        }


        ///
        /// <para><b>Test Identifier</b> - CheckName_NormalTest1()</para>
        /// <para><b>Unique Identifier</b> - AE.E.CN.N.1</para>
        /// <para><b>Description</b> - Method tests the regular use of the method, attempting to set the FirstName variable</para>
        /// <para><b>Method of execution</b> - Automatic</para>
        /// <para><b>Input data</b> - "Frank"</para>
        /// <para><b>Expected outputs</b> - "Frank" set correctly for variable: FirstName</para>
        /// <para><b>Observed outputs</b> - Test passed</para>
        /// <para><b>If Failed</b> - FirstName variable is not set properly, and no logging for that</para>
        ///
        [TestMethod]
        public void CheckName_NormalTest1()
        {
            Employee val = new Employee();
            string input = "Frank";
            bool expected = true;
            bool actual = false;

            actual = val.CheckName(input);

            Assert.AreEqual(expected, actual, "Did not accept valid  name");

        }


        ///
        /// <para><b>Test Identifier</b> - CheckDigit_NormalTest1()</para>
        /// <para><b>Unique Identifier</b> - AE.E.CD.N.1</para>
        /// <para><b>Description</b> - Method tests the regular use of the method, attempting to set the FirstName variable</para>
        /// <para><b>Method of execution</b> - Automatic</para>
        /// <para><b>Input data</b> - "123Frank"</para>
        /// <para><b>Expected outputs</b> - "123Frank" is rejected</para>
        /// <para><b>Observed outputs</b> - Test passed</para>
        /// <para><b>If Failed</b> - Error message stating improper variable is allowed</para>
        ///
        [TestMethod]
        public void CheckDigit_NormalTest1()
        {
            Employee val = new Employee();
            string input = "123Frank";
            bool expected = false;
            bool actual = true;

            actual = val.CheckDigit(input);

            Assert.AreEqual(expected, actual, "Let a string threw with charachters");

        }


        ///
        /// <para><b>Test Identifier</b> - CheckSin_NormalTest1()</para>
        /// <para><b>Unique Identifier</b> - AE.E.CS.N.1</para>
        /// <para><b>Description</b> - Method tests the regular use of the method, attempting to check if sin is valid</para>
        /// <para><b>Method of execution</b> - Automatic</para>
        /// <para><b>Input data</b> - "193 456 787"</para>
        /// <para><b>Expected outputs</b> - "193 456 787" </para>
        /// <para><b>Observed outputs</b> - Test passed</para>
        /// <para><b>If Failed</b> - Error message stating the rejection of valid SIN</para>
        ///
        [TestMethod]
        public void CheckSin_NormalTest1()
        {
            Employee val = new Employee();
            string input = "193 456 787";
            bool expected = false;
            bool actual = true;

            actual = val.CheckDigit(input);

            Assert.AreEqual(expected, actual, "Valid SIN rejected");

        }



        ///
        /// <para><b>Test Identifier</b> - ValidateSin_NormalTest1()</para>
        /// <para><b>Unique Identifier</b> - AE.E.VS.N.1</para>
        /// <para><b>Description</b> - Method tests the regular use of the method, attempting to check if sin is valid</para>
        /// <para><b>Method of execution</b> - Automatic</para>
        /// <para><b>Input data</b> - "193 456 787"</para>
        /// <para><b>Expected outputs</b> - "193 456 787" </para>
        /// <para><b>Observed outputs</b> - Test passed</para>
        /// <para><b>If Failed</b> - Error message stating the rejection of valid SIN</para>
        ///
        //[TestMethod]
        //public void ValidateSin_NormalTest1()
        //{
        //    Employee val = new Employee();
        //    string input = "193 456 787";
        //    bool expected = false;
        //    bool actual = true;

        //    actual = val.validateSIN(input);

        //    Assert.AreEqual(expected, actual, "Valid SIN rejected");

        //}

        ///
        /// <para><b>Test Identifier</b> - CheckDateRange_NormalTest1()</para>
        /// <para><b>Unique Identifier</b> - AE.E.CDR.N.1</para>
        /// <para><b>Description</b> - Method tests the regular use of the method, attempting to check if Date is valid</para>
        /// <para><b>Method of execution</b> - Automatic</para>
        /// <para><b>Input data</b> - "2010 / 03 / 03,2013 / 03 / 03,2011 / 03 / 03"</para>
        /// <para><b>Expected outputs</b> - True </para>
        /// <para><b>Observed outputs</b> - Test passed</para>
        /// <para><b>If Failed</b> - Error message stating the rejection of valid Date</para>
        ///
        [TestMethod]
        public void CheckDataRange_NormalTest1()
        {
            Employee val = new Employee();
            DateTime input1 = new DateTime(2010 / 03 / 03);
            DateTime input2 = new DateTime(2013 / 03 / 03);
            DateTime input3 = new DateTime(2011 / 03 / 03);
 
            bool expected = true;
            bool actual = false;

            actual = val.CheckDateRange(input1,input2,input3);

            Assert.AreEqual(expected, actual, "Valid Date rejected");

        }


        ///
        /// <para><b>Test Identifier</b> - SetDOB_NormalTest1()</para>
        /// <para><b>Unique Identifier</b> - AE.E.SDOB.N.1</para>
        /// <para><b>Description</b> - Method tests the regular use of the method, attempting to check if Date of birth is valid</para>
        /// <para><b>Method of execution</b> - Automatic</para>
        /// <para><b>Input data</b> - "2010 / 03 / 03</para>
        /// <para><b>Expected outputs</b> - True </para>
        /// <para><b>Observed outputs</b> - Test passed</para>
        /// <para><b>If Failed</b> - Error message stating the rejection of valid Date</para>
        ///
        [TestMethod]
        public void SetDOB_NormalTest1()
        {
            Employee val = new Employee();
            string input = "2010 / 03 / 03";

            bool expected = true;
            bool actual = false;

            actual = val.SetDOB(input);

            Assert.AreEqual(expected, actual, "Valid Date rejected");

        }
    }
}
