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
        /// <para><b>Test Identifier</b> - writeLog_Normal1()</para>
        /// <para><b>Unique Identifier</b> - TS.L.wL.N.1</para>
        /// <para><b>Description</b> - Method tests the regular use of the method, attempting to open the test log</para>
        /// <para><b>Method of execution</b> - Automatic</para>
        /// <para><b>Input data</b> - "Frank"</para>
        /// <para><b>Expected outputs</b> - Log opened and written to</para>
        /// <para><b>Observed outputs</b> - Log opened and written to</para>
        /// <para><b>If Failed</b> - Failed to open log file</para>
        /// 
        [TestMethod]
        public void writeLog_NormalTest1()
        {

           Logging val = new Logging();
            string input = "Frank";
            bool expected = true;
            bool actual = false;

            actual = val.writeLog(input);

            Assert.AreEqual(expected, actual, "Failed to write to file");
        }


        ///
        /// <para><b>Test Identifier</b> - openLog_Normal2()</para>
        /// <para><b>Unique Identifier</b> - TS.L.WL.N.1</para>
        /// <para><b>Description</b> - Method tests the regular use of the method, attempting to open the test log</para>
        /// <para><b>Method of execution</b> - Automatic</para>
        /// <para><b>Input data</b> - "This is a test"</para>
        /// <para><b>Expected outputs</b> - Log opened and written to</para>
        /// <para><b>Observed outputs</b> - Log opened and written to</para>
        /// <para><b>If Failed</b> - Failed to open log file</para>
        /// 
        [TestMethod]
        public void writeLog_NormalTest2()
        {

            Logging val = new Logging();
            string input = "This is a test";
            bool expected = true;
            bool actual = false;

            actual = val.writeLog(input);

            Assert.AreEqual(expected, actual, "Failed to write to file");
        }
        
    }
}