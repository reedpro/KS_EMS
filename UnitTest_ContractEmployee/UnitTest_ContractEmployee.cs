//
// FILE: UnitTest_ContractEmployee.cs
// PROJ: INFO2180-14F - Milestone 5 - Test Plan
// NAME: Kivetsu Solutions - Jay, Jordan, Thom, Rachel
// 1stV: 11-28-2014
// DESC: File contains unit test methods for the methods in the ContractEmployee class
//
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AllEmployees;
using Supporting;
///
/// <para>Test Identification</para>
/// <b>[LibraryName].[ClassName].[MethodName].[Normal, Boundary, Exception].[TestNumber]</b> 
/// <=> AE.CE.[ ].[N, B, E].*
///

namespace UnitTest_AllEmployees
{
    [TestClass]
    public class UnitTest_ContractEmployee
    {
        ///
        /// <para><b>Test Identifier</b> - SetContractStartDate_NormalTest1()</para>
        /// <para><b>Unique Identifier</b> - AE.E.SCSD.N.1</para>
        /// <para><b>Description</b> - Method tests the regular use of the method</para>
        /// <para><b>Method of execution</b> - Automatic</para>
        /// <para><b>Input data</b> - "2014/12/03"</para>
        /// <para><b>Expected outputs</b> - "2014/12/03" set correctly for SIN of that employee</para>
        /// <para><b>Observed outputs</b> - passed</para>
        /// <para><b>If Failed</b> - Displays failed message regarding setting the variable</para>
        /// 

        [TestMethod]
        public void SetContractStartDate_NormalTest1()
        {
            string input = "2014/12/03";
            bool expected = true;
            bool actual = false;

            ContractEmployee conE = new ContractEmployee();
            actual = conE.SetContractStartDate(input);
            Assert.AreEqual(expected, actual, "Did not accept valid contract start date");

        }


        ///
        /// <para><b>Test Identifier</b> - SetContractStartDate_NormalTest2()</para>
        /// <para><b>Unique Identifier</b> - AE.E.SCSD.N.2</para>
        /// <para><b>Description</b> - Method tests the regular use of the method</para>
        /// <para><b>Method of execution</b> - Automatic</para>
        /// <para><b>Input data</b> - "10/13/2014"</para>
        /// <para><b>Expected outputs</b> - "2014/12/07" set correctly for SIN of that employee</para>
        /// <para><b>Observed outputs</b> - passed</para>
        /// <para><b>If Failed</b> - Displays failed message regarding setting the variable</para>
        /// 

        [TestMethod]
        public void SetContractStartDate_NormalTest2()
        {
            string input = "2014/12/07";
            bool expected = true;
            bool actual = false;

            ContractEmployee conE = new ContractEmployee();
            actual = conE.SetContractStartDate(input);
            Assert.AreEqual(expected, actual, "Did not accept valid contract start date");

        }


        ///
        /// <para><b>Test Identifier</b> - SetContractStartDate_NormalTest1()</para>
        /// <para><b>Unique Identifier</b> - AE.E.SCSDDT.N.1</para>
        /// <para><b>Description</b> - Method tests the regular use of the method</para>
        /// <para><b>Method of execution</b> - Automatic</para>
        /// <para><b>Input data</b> - "2014/12/03"</para>
        /// <para><b>Expected outputs</b> - "2014/12/03" set Start Date</para>
        /// <para><b>Observed outputs</b> - passed</para>
        /// <para><b>If Failed</b> - Displays failed message regarding setting the variable</para>
        /// 

        [TestMethod]
        public void SetContractStartDate_DateTime_NormalTest1()
        {
            DateTime input = new DateTime(2014 / 12 / 03);
            bool expected = true;
            bool actual = false;

            ContractEmployee conE = new ContractEmployee();
            actual = conE.SetContractStartDate(input);
            Assert.AreEqual(expected, actual, "Did not accept valid contract start date");

        }

        ///
        /// <para><b>Test Identifier</b> - SetContractEndDate_ExceptionTest1()</para>
        /// <para><b>Unique Identifier</b> - AE.E.SCED.E.1</para>
        /// <para><b>Description</b> - Method tests the exceptional use of the method, attempting to set the FirstName variable with invalid format of string</para>
        /// <para><b>Method of execution</b> - Automatic</para>
        /// <para><b>Input data</b> - "제이슨 므라즈"</para>
        /// <para><b>Expected outputs</b> -Throwing excpetion to notify the fact that invalid data is passed in and the failed attempt logged</para>
        /// <para><b>Observed outputs</b> -Test passed</para>
        /// <para><b>If Failed</b> - corrupt data is used to set FirstName variable and/or no logging activity</para>
        ///
        [TestMethod]
        public void SetContractEndDate_ExceptionTest1()
        {
            ContractEmployee val = new ContractEmployee();
            string input = "제이슨 므라즈";
            bool expected = false;
            bool actual = true;

            actual = val.SetContractEndDate(input);

            Assert.AreEqual(expected, actual, "Accepted false contract end date");
        }

        ///
        /// <para><b>Test Identifier</b> - SetContractEndDate_NormalTest1()</para>
        /// <para><b>Unique Identifier</b> - AE.E.SCEDDTDT.N.1</para>
        /// <para><b>Description</b> - Method tests the regular use of the method</para>
        /// <para><b>Method of execution</b> - Automatic</para>
        /// <para><b>Input data</b> - "2014/12/03"</para>
        /// <para><b>Expected outputs</b> - "2014/12/03" set end date</para>
        /// <para><b>Observed outputs</b> - passed</para>
        /// <para><b>If Failed</b> - Displays failed message regarding setting the variable</para>
        /// 

        [TestMethod]
        public void SetContractEndDate_DateTime_NormalTest1()
        {
            DateTime input = new DateTime(2014 / 12 / 03);
            bool expected = true;
            bool actual = false;

            ContractEmployee conE = new ContractEmployee();
            actual = conE.SetContractEndDate(input);
            Assert.AreEqual(expected, actual, "Did not accept valid contract start date");

        }


        ///
        /// <para><b>Test Identifier</b> - SetContractEndDate_ExceptionTest1()</para>
        /// <para><b>Unique Identifier</b> - AE.E.SCED.E.1</para>
        /// <para><b>Description</b> - Method tests the exceptional use of the method, attempting to set the FirstName variable with invalid format of string</para>
        /// <para><b>Method of execution</b> - Automatic</para>
        /// <para><b>Input data</b> - "Hello"</para>
        /// <para><b>Expected outputs</b> -Throwing excpetion to notify the fact that invalid data is passed in and the failed attempt logged</para>
        /// <para><b>Observed outputs</b> - Test Passed</para>
        /// <para><b>If Failed</b> - corrupt data is used to set FirstName variable and/or no logging activity</para>
        ///
        [TestMethod]
        public void SetContractEndDate_ExceptionTest2()
        {
            ContractEmployee val = new ContractEmployee();
            string input = "Hello";
            bool expected = false;
            bool actual = true;

            actual = val.SetContractEndDate(input);

            Assert.AreEqual(expected, actual, "Accepted false contract end date");
        }


        ///
        /// <para><b>Test Identifier</b> - CheckFixedContractAmt_String_NormalTest1()</para>
        /// <para><b>Unique Identifier</b> - AE.E.CFCAD.N.1</para>
        /// <para><b>Description</b> - Method tests the regular use of the method</para>
        /// <para><b>Method of execution</b> - Automatic</para>
        /// <para><b>Input data</b> - "15.00"</para>
        /// <para><b>Expected outputs</b> - "True"</para>
        /// <para><b>Observed outputs</b> - passed</para>
        /// <para><b>If Failed</b> - Displays failed message regarding setting the variable</para>
        /// 

        [TestMethod]
        public void CheckFixedContractAmt_String_NormalTest1()
        {
            string input = "15.00";
            bool expected = true;
            bool actual = false;

            ContractEmployee conE = new ContractEmployee();
            actual = conE.CheckFixedContractAmt(input);
            Assert.AreEqual(expected, actual, "Did not accept valid contract start date");

        }


        ///
        /// <para><b>Test Identifier</b> - SetFixedContractAmt_String_NormalTest1()</para>
        /// <para><b>Unique Identifier</b> - AE.E.SFCAD.N.1</para>
        /// <para><b>Description</b> - Method tests the regular use of the method</para>
        /// <para><b>Method of execution</b> - Automatic</para>
        /// <para><b>Input data</b> - "15.00"</para>
        /// <para><b>Expected outputs</b> - "True"</para>
        /// <para><b>Observed outputs</b> - passed</para>
        /// <para><b>If Failed</b> - Displays failed message regarding setting the variable</para>
        /// 

        [TestMethod]
        public void SetFixedContractAmt_String_NormalTest1()
        {
            string input = "15.00";
            bool expected = true;
            bool actual = false;

            ContractEmployee conE = new ContractEmployee();
            actual = conE.SetFixedContractAmt(input);
            Assert.AreEqual(expected, actual, "Did not accept valid contract start date");

        }
        ///
        /// <para><b>Test Identifier</b> - CheckFixedContractAmt_Decimal_NormalTest1()</para>
        /// <para><b>Unique Identifier</b> - AE.E.CFCAD.N.1</para>
        /// <para><b>Description</b> - Method tests the regular use of the method</para>
        /// <para><b>Method of execution</b> - Automatic</para>
        /// <para><b>Input data</b> - "15.00"</para>
        /// <para><b>Expected outputs</b> - "True"</para>
        /// <para><b>Observed outputs</b> - passed</para>
        /// <para><b>If Failed</b> - Displays failed message regarding setting the variable</para>
        /// 

        [TestMethod]
        public void CheckFixedContractAmt_Decimal_NormalTest1()
        {
            Decimal input = 15.00m;
            bool expected = true;
            bool actual = false;

            ContractEmployee conE = new ContractEmployee();
            actual = conE.CheckFixedContractAmt(input);
            Assert.AreEqual(expected, actual, "Did not accept valid contract start date");
        }

        ///
        /// <para><b>Test Identifier</b> - SetFixedContractAmt_Decimal_NormalTest1()</para>
        /// <para><b>Unique Identifier</b> - AE.E.SFCAD.N.1</para>
        /// <para><b>Description</b> - Method tests the regular use of the method</para>
        /// <para><b>Method of execution</b> - Automatic</para>
        /// <para><b>Input data</b> - "15.00"</para>
        /// <para><b>Expected outputs</b> - "True"</para>
        /// <para><b>Observed outputs</b> - passed</para>
        /// <para><b>If Failed</b> - Displays failed message regarding setting the variable</para>
        /// 

        [TestMethod]
        public void SetFixedContractAmt_Decimal_NormalTest1()
        {
            Decimal input = 15.00m;
            bool expected = true;
            bool actual = false;

            ContractEmployee conE = new ContractEmployee();
            actual = conE.SetFixedContractAmt(input);
            Assert.AreEqual(expected, actual, "Did not accept valid contract start date");
        }
    }
}
