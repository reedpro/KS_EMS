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
        /// <para><b>Test Identifier</b> - openLog_Normal1()</para>
        /// <para><b>Unique Identifier</b> - TS.L.OL.N.1</para>
        /// <para><b>Description</b> - Method tests the regular use of the method, attempting to open the test log</para>
        /// <para><b>Method of execution</b> - Automatic</para>
        /// <para><b>Input data</b> - "\test.log"</para>
        /// <para><b>Expected outputs</b> - Log opened</para>
        /// <para><b>Observed outputs</b> - Log opened</para>
        /// <para><b>If Failed</b> - Failed to open log file</para>
        /// 
        [TestMethod]
        public void openLog_NormalTest1
        {

        }

        ///
        /// <para><b>Test Identifier</b> - closeLog_Normal1()</para>
        /// <para><b>Unique Identifier</b> - TS.L.CL.N.1</para>
        /// <para><b>Description</b> - Method tests the regular use of the method, attempting to close the test log</para>
        /// <para><b>Method of execution</b> - Automatic</para>
        /// <para><b>Input data</b> - none</para>
        /// <para><b>Expected outputs</b> - Log closed</para>
        /// <para><b>Observed outputs</b> - Log closed</para>
        /// <para><b>If Failed</b> - Failed to close log file</para>
        /// 
        [TestMethod]
        public void closeLog_NormalTest1
        {

        }

        ///
        /// <para><b>Test Identifier</b> - WriteLog_Exception1()</para>
        /// <para><b>Unique Identifier</b> - TS.L.WL.E.1</para>
        /// <para><b>Description</b> - Method tests the writing to the log while it is not open</para>
        /// <para><b>Method of execution</b> - Automatic</para>
        /// <para><b>Input data</b> - none</para>
        /// <para><b>Expected outputs</b> - Cannot write to log while it is not open</para>
        /// <para><b>Observed outputs</b> - Cannot write to log while it is not open</para>
        /// <para><b>If Failed</b> - Did not fail while log is not opened</para>
        /// 
        [TestMethod]
        public void writeLog_ExceptionTest1
        {

        }

        ///
        /// <para><b>Test Identifier</b> - closeLog_Exception1()</para>
        /// <para><b>Unique Identifier</b> - TS.L.CL.E.1</para>
        /// <para><b>Description</b> - Method tests the  attempting to close the test log while it is not open</para>
        /// <para><b>Method of execution</b> - Automatic</para>
        /// <para><b>Input data</b> - none</para>
        /// <para><b>Expected outputs</b> - Cannot close a file while none are open</para>
        /// <para><b>Observed outputs</b> - Cannot close a file while none are open</para>
        /// <para><b>If Failed</b> - Closed file that isnt open</para>
        /// 
        [TestMethod]
        public void closeLog_ExceptionTest1
        {

        }
    }
}