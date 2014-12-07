//
// FILE: UnitTest_FullTimeEmployee.cs
// PROJ: INFO2180-14F - Milestone 5 - Test Plan
// NAME: Jay Moorhouse, Jordan, Thom, Rachel Park
// 1stV: 11-28-2014
// DESC: File contains unit test methods for the methods in the FullTimeEmployee class
//
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AllEmployees;
using Supporting;

///
/// <para>Test Identification</para>
/// <b>[LibraryName].[ClassName].[MethodName].[Normal, Boundary, Exception].[TestNumber]</b> 
/// <=> AE.FTE.[ ].[N, B, E].*
///

namespace UnitTest_AllEmployees
{
    [TestClass]
    public class UnitTest_FullTimeEmployee
    {
        ///
        /// <para><b>Test Identifier</b> - SetDateOfHire_NormalTest1()</para>
        /// <para><b>Unique Identifier</b> - AE.FTE.SDH.N.1</para>
        /// <para><b>Description</b> - Method tests the regular use of the method, attempting to set the dateOfHire variable</para>
        /// <para><b>Method of execution</b> - Automatic</para>
        /// <para><b>Input data</b> - "11/31/2014"</para>
        /// <para><b>Expected outputs</b> - "11/31/2014" set correctly for variable: dateOfHire</para>
        /// <para><b>Observed outputs</b> - "11/31/2014" set correctly for variable: dateOfHire</para>
        /// <para><b>If Failed</b> - Displays failed message regarding setting the variable</para>
        /// 
        [TestMethod]
        public void SetDateOfHire_NormalTest1()
        {
            string input = "11/31/2014";
            bool expected = true;
            bool actual = false;

            FulltimeEmployee fulE = new FulltimeEmployee();
            actual = fulE.SetDateOfHire(input);
            Assert.AreEqual(expected, actual, "Did not accept valid date of hire");

        }

        ///
        /// <para><b>Test Identifier</b> - SetDateOfTermination_NormalTest1()</para>
        /// <para><b>Unique Identifier</b> - AE.FTE.SDT.N.1</para>
        /// <para><b>Description</b> - Method tests the regular use of the method, attempting to set the dateOfTermination variable</para>
        /// <para><b>Method of execution</b> - Automatic</para>
        /// <para><b>Input data</b> - "12/14/2014"</para>
        /// <para><b>Expected outputs</b> - "12/14/2014" set correctly for variable: dateOfTermination</para>
        /// <para><b>Observed outputs</b> - "12/14/2014" set correctly for variable: dateOfTermination</para>
        /// <para><b>If Failed</b> - Displays failed message regarding setting the variable</para>
        ///
        [TestMethod]
        public void SetDateOfTermination_NormalTest1()
        {
            string input = "12/14/2014";
            bool expected = true;
            bool actual = false;

            FulltimeEmployee fulE = new FulltimeEmployee();
            actual = fulE.SetDateOfHire(input);
            Assert.AreEqual(expected, actual, "Did not accept valid date of hire");
        }

        ///
        /// <para><b>Test Identifier</b> - SetDateOfHire_ExceptionTest1()</para>
        /// <para><b>Unique Identifier</b> - AE.FTE.SDH.E.1</para>
        /// <para><b>Description</b> - Method tests exceptional use of the method, attempting to set the dateOfHire variable to illegal data type</para>
        /// <para><b>Method of execution</b> - Automatic</para>
        /// <para><b>Input data</b> - "today"</para>
        /// <para><b>Expected outputs</b> - "today" rejected as input</para>
        /// <para><b>Observed outputs</b> - "today" rejected as input</para>
        /// <para><b>If Failed</b> - Displays failed message regarding setting the variable</para>
        ///
        [TestMethod]
        public void SetDateOfHire_ExceptionTest1()
        {

            string input = "today";
            bool expected = false;
            bool actual = true;

            FulltimeEmployee fulE = new FulltimeEmployee();
            actual = fulE.SetDateOfHire(input);
            Assert.AreEqual(expected, actual, "Allowed inproper date");

        }

        ///
        /// <para><b>Test Identifier</b> - SetDateOfTermination_ExceptionTest1()</para>
        /// <para><b>Unique Identifier</b> - AE.FTE.SDT.E.1</para>
        /// <para><b>Description</b> - Method tests exceptional use of the method, attempting to set the dateOfTermination variable to illegal data type</para>
        /// <para><b>Method of execution</b> - Automatic</para>
        /// <para><b>Input data</b> - "Yesterday"</para>
        /// <para><b>Expected outputs</b> - "false" rejected as input</para>
        /// <para><b>Observed outputs</b> - "Yesterday" rejected as input</para>
        /// <para><b>If Failed</b> - Displays failed message regarding setting the variable</para>
        ///
        [TestMethod]
        public void SetDateOfTermination_ExceptionTest1()
        {
            string input = "yesterday";
            bool expected = false;
            bool actual = true;

            FulltimeEmployee fulE = new FulltimeEmployee();
            actual = fulE.SetDateOfHire(input);
            Assert.AreEqual(expected, actual, "Allowed inproper date");

        }
    }
}
 

