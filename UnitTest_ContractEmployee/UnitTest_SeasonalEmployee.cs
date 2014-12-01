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
        public void SetPiecePay_ExceptionTest1()
        {

        }
    }
}


