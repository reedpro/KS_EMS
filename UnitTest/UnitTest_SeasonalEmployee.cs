//
// FILE: UnitTest_SeasonalEmployee.cs
// PROJ: INFO2180-14F - Milestone 5 - Test Plan
// NAME: Kivetsu Solutions - Jay, Jordan, Thom, Rachel
// 1stV: 11-28-2014
// DESC: File contains unit test methods for the methods in the SeasonalEmployee class
//
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AllEmployees;
using Supporting;

///
/// <para>Test Identification</para>
/// <b>[LibraryName].[ClassName].[MethodName].[Normal, Boundary, Exception].[TestNumber]</b> 
/// <=> AE.SE.[ ].[N, B, E].*
///

namespace UnitTest_AllEmployees
{
    [TestClass]
    public class UnitTest_SeasonalEmployee
    {
        ///
        /// <para><b>Test Identifier</b> - SetSeason_NormalTest1()</para>
        /// <para><b>Unique Identifier</b> - AE.SE.SS.N.1</para>
        /// <para><b>Description</b> - Method tests the regular use of the method, attempting to set the season variable</para>
        /// <para><b>Method of execution</b> - Automatic</para>
        /// <para><b>Input data</b> - "Winter"</para>
        /// <para><b>Expected outputs</b> - "Winter" set correctly for variable: season</para>
        /// <para><b>Observed outputs</b> - "Winter" set correctly for variable: season</para>
        /// <para><b>If Failed</b> - Displays failed message regarding setting the variable</para>
        /// 
        [TestMethod]
        public void SetSeason_NormalTest1()
        {
            SeasonalEmployee val = new SeasonalEmployee();
            string input = "Winter";
            bool expected = true;
            bool actual = false;

            actual = val.SetSeason(input);

            Assert.AreEqual(expected, actual, "Did not accept proper Season");
        }

        ///
        /// <para><b>Test Identifier</b> - SetPiecePay_NormalTest1()</para>
        /// <para><b>Unique Identifier</b> - AE.SE.SPP.N.1</para>
        /// <para><b>Description</b> - Method tests the regular use of the method, attempting to set the piecePay variable</para>
        /// <para><b>Method of execution</b> - Automatic</para>
        /// <para><b>Input data</b> - "10.50"</para>
        /// <para><b>Expected outputs</b> - "10.50" set correctly for variable: piecePay</para>
        /// <para><b>Observed outputs</b> - "10.50" set correctly for variable: piecePay</para>
        /// <para><b>If Failed</b> - Displays failed message regarding setting the variable</para>
        /// 
        [TestMethod]
        public void SetPiecePay_NormalTest1()
        {
            SeasonalEmployee val = new SeasonalEmployee();
            Decimal input = 10.50m;
            bool expected = true;
            bool actual = false;

            actual = val.SetPiecePay(input);

            Assert.AreEqual(expected, actual, "Failed to set proper Piece Pay");
        }

        ///
        /// <para><b>Test Identifier</b> - SetSeason_ExceptionTest1()</para>
        /// <para><b>Unique Identifier</b> - AE.SE.SS.E.1</para>
        /// <para><b>Description</b> - Method tests the exceptional use of the method, attempting to set the season variable to an invalid value</para>
        /// <para><b>Method of execution</b> - Automatic</para>
        /// <para><b>Input data</b> - "Frall"</para>
        /// <para><b>Expected outputs</b> - "Frall" failed to set correctly for variable: season</para>
        /// <para><b>Observed outputs</b> - "Frall" failed set correctly for variable: season</para>
        /// <para><b>If Failed</b> - Displays failed message regarding setting the variable</para>
        /// 
        [TestMethod]
        public void SetSeason_ExceptionTest1()
        {
            SeasonalEmployee val = new SeasonalEmployee();
            string input = "Frall";
            bool expected = false;
            bool actual = true;

            actual = val.SetPiecePay(input);

            Assert.AreEqual(expected, actual, "Accepted improper input");
        }

        ///
        /// <para><b>Test Identifier</b> - SetSeason_ExceptionTest1()</para>
        /// <para><b>Unique Identifier</b> - AE.SE.SPP.E.1</para>
        /// <para><b>Description</b> - Method tests the exceptional use of the method, attempting to set the season variable to an invalid value</para>
        /// <para><b>Method of execution</b> - Automatic</para>
        /// <para><b>Input data</b> - "a bit"</para>
        /// <para><b>Expected outputs</b> - "a bit" failed to set correctly for variable: piecePay</para>
        /// <para><b>Observed outputs</b> - "a bit" failed set correctly for variable: piecePay</para>
        /// <para><b>If Failed</b> - Displays failed message regarding setting the variable</para>
        /// 
        [TestMethod]
        public void CheckPiecePay_ExceptionTest1()
        {
            SeasonalEmployee val = new SeasonalEmployee();
            string input = "a bit";
            bool expected =false;
            bool actual = true;

            actual = val.CheckPiecePay(input);

            Assert.AreEqual(expected, actual, "Allowed improper piece pay");
        }


        ///
        /// <para><b>Test Identifier</b> - CheckPiecePay_decimal_NormalTest1()</para>
        /// <para><b>Unique Identifier</b> - AE.SE.CPP.N.1</para>
        /// <para><b>Description</b> - Method tests the regular use of the method, attempting to set the piecePay variable</para>
        /// <para><b>Method of execution</b> - Automatic</para>
        /// <para><b>Input data</b> - "10.50"</para>
        /// <para><b>Expected outputs</b> - "10.50" set correctly for variable: piecePay</para>
        /// <para><b>Observed outputs</b> - "10.50" set correctly for variable: piecePay</para>
        /// <para><b>If Failed</b> - Displays failed message regarding setting the variable</para>
        /// 
        [TestMethod]
        public void CheckPiecePay_decimal_NormalTest1()
        {
            SeasonalEmployee val = new SeasonalEmployee();
            Decimal input = 10.50m;
            bool expected = true;
            bool actual = false;

            actual = val.CheckPiecePay(input);

            Assert.AreEqual(expected, actual, "Failed to check piece pay input");
        }

        ///
        /// <para><b>Test Identifier</b> - CheckSeason_NormalTest1()</para>
        /// <para><b>Unique Identifier</b> - AE.SE.CS.N.1</para>
        /// <para><b>Description</b> - Method tests the regular use of the method, attempting to set the season variable</para>
        /// <para><b>Method of execution</b> - Automatic</para>
        /// <para><b>Input data</b> - "Winter"</para>
        /// <para><b>Expected outputs</b> - "Winter" set correctly for variable: season</para>
        /// <para><b>Observed outputs</b> - "Winter" set correctly for variable: season</para>
        /// <para><b>If Failed</b> - Displays failed message regarding setting the variable</para>
        /// 
        [TestMethod]
        public void CheckSeason_NormalTest1()
        {
            SeasonalEmployee val = new SeasonalEmployee();
            string input = "Winter";
            bool expected = true;
            bool actual = false;

            actual = val.CheckSeason(input);

            Assert.AreEqual(expected, actual, "Valid season rejected");
        }

    }
}


