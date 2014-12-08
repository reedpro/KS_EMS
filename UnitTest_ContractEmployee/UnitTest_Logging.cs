//
// FILE: UnitTest_Logging.cs
// PROJ: INFO2180-14F - Milestone 5 - Test Plan
// NAME: Jay Moorhouse, Jordan, Thom, Rachel Park
// 1stV: 11-28-2014
// DESC: File contains unit test methods for the methods in the Logging class
//
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Supporting;

///
/// <para>Test Identification</para>
/// <b>[LibraryName].[ClassName].[MethodName].[Normal, Boundary, Exception].[TestNumber]</b> 
/// <=> TS.L.[ ].[N, B, E].*
///

namespace UnitTest_Supporting
{
    [TestClass]
    public class UnitTest_Logging
    {
        

        ///
        /// <para><b>Test Identifier</b> - WriteLog_NormalTest1()</para>
        /// <para><b>Unique Identifier</b> - TS.L.WL.E.1</para>
        /// <para><b>Description</b> - Method tests the writing to the log while it is not open</para>
        /// <para><b>Method of execution</b> - Automatic</para>
        /// <para><b>Input data</b> - "This is a test"</para>
        /// <para><b>Expected outputs</b> Will write to logging file- </para>
        /// <para><b>Observed outputs</b> - writes to logging file</para>
        /// <para><b>If Failed</b> -Will not write to loggin file</para>
        /// 
        [TestMethod]
        public void writeLog_NormalTest1()
        {
            Logging val = new Logging();
            string input = "This is test";
            bool expected = true;
            bool actual = false;

            actual = val.writeLog(input);

            Assert.AreEqual(expected, actual, "Did not write to file");
        }


        ///
        /// <para><b>Test Identifier</b> - WriteLog_NormalTest()</para>
        /// <para><b>Unique Identifier</b> - TS.L.WL.E.1</para>
        /// <para><b>Description</b> - Method tests the writing to the log while it is not open</para>
        /// <para><b>Method of execution</b> - Automatic</para>
        /// <para><b>Input data</b> - "TestWithOneString"</para>
        /// <para><b>Expected outputs</b> Will write to logging file- </para>
        /// <para><b>Observed outputs</b> - writes to logging file</para>
        /// <para><b>If Failed</b> -Will not write to loggin file</para>
        /// 
        [TestMethod]
        public void writeLog_NormalTest1()
        {
            Logging val = new Logging();
            string input = "TestWithOneString";
            bool expected = true;
            bool actual = false;

            actual = val.writeLog(input);

            Assert.AreEqual(expected, actual, "Did not write to file");
        }
   
    }
}