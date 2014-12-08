//
// FILE: UnitTest_PartTimeEmployee.cs
// PROJ: INFO2180-14F - Milestone 5 - Test Plan
// NAME: Kivetsu Solutions - Jay, Jordan, Thom, Rachel
// 1stV: 11-28-2014
// DESC: File contains unit test methods for the methods in the PartTimeEmployee class
//
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AllEmployees;
using Supporting;

///
/// <para>Test Identification</para>
/// <b>[LibraryName].[ClassName].[MethodName].[Normal, Boundary, Exception].[TestNumber]</b> 
/// <=> AE.PTE.[ ].[N, B, E].*
///

namespace UnitTest_AllEmployees
{
    [TestClass]
    public class UnitTest_PartTimeEmployee
    {
        ///
        /// <para><b>Test Identifier</b> - SetHourlyRate_NormalTest1()</para>
        /// <para><b>Unique Identifier</b> - AE.PTE.SHR.N.1</para>
        /// <para><b>Description</b> - Method tests the regular use of the method, attempting to set the hourlyRate variable</para>
        /// <para><b>Method of execution</b> - Automatic</para>
        /// <para><b>Input data</b> - "18.50"</para>
        /// <para><b>Expected outputs</b> - "18.50" set correctly for variable: hourlyRate</para>
        /// <para><b>Observed outputs</b> - "18.50" set correctly for variable: hourlyRate</para>
        /// <para><b>If Failed</b> - Displays failed message regarding setting the variable</para>
        /// 
        [TestMethod]
        public void SetHourlyRate_NormalTest1()
        {
            Decimal input = 18.50m;
            bool expected = true;
            bool actual = false;

            ParttimeEmployee partE = new ParttimeEmployee();
            actual = partE.SetHourlyRate(input);
            Assert.AreEqual(expected, actual, "Did not accept valid hourly rate");
        }

        ///
        /// <para><b>Test Identifier</b> - SetHourlyRate_NormalTest2()</para>
        /// <para><b>Unique Identifier</b> - AE.PTE.SHR.N.2</para>
        /// <para><b>Description</b> - Method tests the regular use of the method, attempting to set the hourlyRate variable</para>
        /// <para><b>Method of execution</b> - Automatic</para>
        /// <para><b>Input data</b> - "15"</para>
        /// <para><b>Expected outputs</b> - "15" set correctly for variable: hourlyRate</para>
        /// <para><b>Observed outputs</b> - "15" set correctly for variable: hourlyRate</para>
        /// <para><b>If Failed</b> - Displays failed message regarding setting the variable</para>
        /// 
        [TestMethod]
        public void SetHourlyRate_NormalTest2()
        {
            Decimal input = 15;
            bool expected = true;
            bool actual = false;

            ParttimeEmployee partE = new ParttimeEmployee();
            actual = partE.SetHourlyRate(input);
            Assert.AreEqual(expected, actual, "Did not accept valid hourly rate");

        }

        ///
        /// <para><b>Test Identifier</b> - SetHourlyRate_ExceptionTest1()</para>
        /// <para><b>Unique Identifier</b> - AE.PTE.SHR.E.1</para>
        /// <para><b>Description</b> - Method tests the exceptional use of the method, attempting to set the hourlyRate variable to an illegal value</para>
        /// <para><b>Method of execution</b> - Automatic</para>
        /// <para><b>Input data</b> - "fifteen"</para>
        /// <para><b>Expected outputs</b> - "fifteen" to be rejected as input, and an exception thrown</para>
        /// <para><b>Observed outputs</b> - "fifteen" to be rejected as input, and an exception thrown</para>
        /// <para><b>If Failed</b> - Displays failed message regarding setting the variable</para>
        /// 
        [TestMethod]
        public void SetHourlyRate_ExceptionTest1()
        {
            string input = "fifteen";
            bool expected = false;
            bool actual = true;

            ParttimeEmployee partE = new ParttimeEmployee();
            actual = partE.SetHourlyRate(input);
            Assert.AreEqual(expected, actual, "Allowed invalid data");

        }

        ///
        /// <para><b>Test Identifier</b> - SetHourlyRate_ExceptionTest2()</para>
        /// <para><b>Unique Identifier</b> - AE.PTE.SHR.E.2</para>
        /// <para><b>Description</b> - Method tests the exceptional use of the method, attempting to set the hourlyRate variable to an illegal value</para>
        /// <para><b>Method of execution</b> - Automatic</para>
        /// <para><b>Input data</b> - "0"</para>
        /// <para><b>Expected outputs</b> - "0" to be rejected as input</para>
        /// <para><b>Observed outputs</b> - 0"" to be rejected as input</para>
        /// <para><b>If Failed</b> - Displays failed message regarding setting the variable</para>
        /// 
        [TestMethod]
        public void SetHourlyRate_ExceptionTest2()
        {
            string input = "-13";
            bool expected = false;
            bool actual = true;

            ParttimeEmployee partE = new ParttimeEmployee();
            actual = partE.SetHourlyRate(input);
            Assert.AreEqual(expected, actual, "Allowed invalid data");
        }

        ///
        /// <para><b>Test Identifier</b> - SetDateOfHire_NormalTest1()</para>
        /// <para><b>Unique Identifier</b> - AE.PTE.SDOH.N.1</para>
        /// <para><b>Description</b> - Method tests the exceptional use of the method, attempting to set the hourlyRate variable to an illegal value</para>
        /// <para><b>Method of execution</b> - Automatic</para>
        /// <para><b>Input data</b> - "2010/03/03"</para>
        /// <para><b>Expected outputs</b> - "2013/03/03" to be rejected as input</para>
        /// <para><b>Observed outputs</b> - "Test passed" to be rejected as input</para>
        /// <para><b>If Failed</b> - Displays failed message regarding setting the variable</para>
        /// 
        [TestMethod]
        public void SetDateOfHire_NormalTest1()
        {
            DateTime input = new DateTime(2010/03/03);
            bool expected = true;
            bool actual = false;

            ParttimeEmployee partE = new ParttimeEmployee();
            actual = partE.SetDateOfHire(input);
            Assert.AreEqual(expected, actual, "Does not accept proper data");
        }

        ///
        /// <para><b>Test Identifier</b> - SetDateOfTermination_NormalTest1()</para>
        /// <para><b>Unique Identifier</b> - AE.PTE.SDOt.N.1</para>
        /// <para><b>Description</b> - Method tests the exceptional use of the method, attempting to set the hourlyRate variable to an illegal value</para>
        /// <para><b>Method of execution</b> - Automatic</para>
        /// <para><b>Input data</b> - "2010/03/03"</para>
        /// <para><b>Expected outputs</b> - "2013/03/03" to be rejected as input</para>
        /// <para><b>Observed outputs</b> - "Test passed" to be rejected as input</para>
        /// <para><b>If Failed</b> - Displays failed message regarding setting the variable</para>
        /// 
        [TestMethod]
        public void SetDateOfTermination_NormalTest1()
        {
            DateTime input = new DateTime(2010 / 03 / 03);
            bool expected = true;
            bool actual = false;

            ParttimeEmployee partE = new ParttimeEmployee();
            actual = partE.SetDateOfTermination(input);
            Assert.AreEqual(expected, actual, "Does not accept proper data");
        }


        ///
        /// <para><b>Test Identifier</b> - CheckHourlyRate_NormalTest1()</para>
        /// <para><b>Unique Identifier</b> - AE.PTE.CHR.N.1</para>
        /// <para><b>Description</b> - Method tests the exceptional use of the method, attempting to set the hourlyRate variable to an illegal value</para>
        /// <para><b>Method of execution</b> - Automatic</para>
        /// <para><b>Input data</b> - "13.00"</para>
        /// <para><b>Expected outputs</b> - "13.00" to be rejected as input</para>
        /// <para><b>Observed outputs</b> - Test passed</para>
        /// <para><b>If Failed</b> - Displays failed message regarding setting the variable</para>
        /// 
        [TestMethod]
        public void CheckHourlyRate_NormalTest1()
        {
            Decimal input = 13.00m;
            bool expected = true;
            bool actual =false;

            ParttimeEmployee partE = new ParttimeEmployee();
            actual = partE.CheckHourlyRate(input);
            Assert.AreEqual(expected, actual, "Did not allow valid data");
        }



    }
}
