//
// FILE: UnitTest_FileIO.cs
// PROJ: INFO2180-14F - Milestone 5 - Test Plan
// NAME: Jay Moorhouse, Jordan, Thom, Rachel Park
// 1stV: 11-28-2014
// DESC: File contains unit test methods for the methods in the FileIO class
//
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Supporting;

///
/// <para>Test Identification</para>
/// <b>[LibraryName].[ClassName].[MethodName].[Normal, Boundary, Exception].[TestNumber]</b> 
/// <=> TS.FIO.[ ].[N, B, E].*
///

namespace UnitTest_FileIO
{
    [TestClass]
    public class UnitTest_FileIO
    {
        ///
        /// <para><b>Test Identifier</b> - dBaseOpen_W_Normal1()</para>
        /// <para><b>Unique Identifier</b> - TS.FIO.DBOR.N.1</para>
        /// <para><b>Description</b> - Method tests the regular use of the method, attempting to open an existing file </para>
        /// <para><b>Method of execution</b> - Automatic</para>
        /// <para><b>Input data</b> - ""</para>
        /// <para><b>Expected outputs</b> - "File opened safely</para>
        /// <para><b>Observed outputs</b> - "File opened</para>
        /// <para><b>If Failed</b> - Displays failed message regarding opening the file</para>
        /// 
        [TestMethod]
        public void dBaseOpen_W_NormalTest1()
        {
            String[] input = { "test1" ,"test2" };
            FileIO file = new FileIO();
            file.dBaseOpen_W(input);
           //This Test must be manually checked to ensure that the test strings have been written to a file
        }

        ///
        /// <para><b>Test Identifier</b> - readDataBase_Normal1()</para>
        /// <para><b>Unique Identifier</b> - TS.FIO.RDB.N.1</para>
        /// <para><b>Description</b> - Method tests the regular use of the method, attempting to read the database in from a file </para>
        /// <para><b>Method of execution</b> - Automatic</para>
        /// <para><b>Input data</b> - "C:\Windows\Test.txt"</para>
        /// <para><b>Expected outputs</b> - "Database read in"</para>
        /// <para><b>Observed outputs</b> - "Database read in"</para>
        /// <para><b>If Failed</b> - Displays failed message regarding reading the file</para>
        /// 
        [TestMethod]
        public void readDataBase_NormalTest1()
        {

        }

        ///
        /// <para><b>Test Identifier</b> - ReadDataBase_ExceptionTest1()</para>
        /// <para><b>Unique Identifier</b> - TS.FIO.RDB.E.1</para>
        /// <para><b>Description</b> - Method tests an exception, by trying to read a database without opening a file first</para>
        /// <para><b>Method of execution</b> - Automatic</para>
        /// <para><b>Input data</b> - None</para>
        /// <para><b>Expected outputs</b> - ERROR: No file</para>
        /// <para><b>Observed outputs</b> - ERROR</para>
        /// <para><b>If Failed</b> - Didnt call exception with no file open</para>
        ///
        [TestMethod]
        public void ReadDataBase_ExceptionTest1()
        {

        }

        ///
        /// <para><b>Test Identifier</b> - WriteDataBase_ExceptionTest1()</para>
        /// <para><b>Unique Identifier</b> - TS.FIO.WDB.E.1</para>
        /// <para><b>Description</b> - Method tests an exception, by trying to write a corupt database to a file</para>
        /// <para><b>Method of execution</b> - Automatic</para>
        /// <para><b>Input data</b> - None</para>
        /// <para><b>Expected outputs</b> - ERROR: Database is not correct</para>
        /// <para><b>Observed outputs</b> - ERROR</para>
        /// <para><b>If Failed</b> - Wrote corrupt database to file</para>
        ///
        [TestMethod]
        public void WriteDataBase_ExceptionTest1()
        {

        }
    }
}


