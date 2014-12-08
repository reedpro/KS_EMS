//
// FILE: UnitTest_Container.cs
// PROJ: INFO2180-14F - Milestone 5 - Test Plan
// NAME: Kivetsu Solutions - Jay, Jordan, Thom, Rachel
// 1stV: 11-28-2014
// DESC: File contains unit test methods for the methods in the Container class
//
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AllEmployees;
using Supporting;
using System.Collections.Generic;

///
/// <para>Test Identification</para>
/// <b>[LibraryName].[ClassName].[MethodName].[Normal, Boundary, Exception].[TestNumber]</b> 
/// <=> TC.C.[ ].[N, B, E].*
///

namespace UnitTest_AllEmployees
{
    [TestClass]
    public class UnitTest_Container
    {
        ///
        /// <para><b>Test Identifier</b> - AddEmployee_Normal1()</para>
        /// <para><b>Unique Identifier</b> - TC.C.AE.N.1</para>
        /// <para><b>Description</b> - Method tests the regular use of the method, attempting to add new data for Employee entry</para>
        /// <para><b>Method of execution</b> - Automatic</para>
        /// <para><b>Input data</b> - Employee</para>
        /// <para><b>Expected outputs</b> - The passed in Employee object added to the container and log it in a log file</para>
        /// <para><b>Observed outputs</b> - Test passed</para>
        /// <para><b>If Failed</b> - Displays failed message regarding the attempt to add an employee object and log it in a log file</para>
        /// 
        [TestMethod]
        public void AddEmployee_NormalTest1(Employee newEmployee)
        {
           
            TheCompany.Container Cont = new TheCompany.Container();
            Employee input = new Employee();
            bool expected = true;
            bool actual = false;

            actual = Cont.AddEmployee(input);

            Assert.AreEqual(expected, actual, "Did not add a new employee");
            
        }


        ///
        /// <para><b>Test Identifier</b> - FindEmployee_Exception1()</para>
        /// <para><b>Unique Identifier</b> - TC.C.FE.E1</para>
        /// <para><b>Description</b> - Method tests the exceptional use of the method, attempting to find if a invalid object</para>
        /// <para><b>Method of execution</b> - Automatic</para>
        /// <para><b>Input data</b> - input1 firstname, input2 fail</para>
        /// <para><b>Expected outputs</b> - Throw exception notifying that the passed in parameter is not valid format and log it in a log file</para>
        /// <para><b>Observed outputs</b> - Test passed</para>
        /// <para><b>If Failed</b> - corrupt data might be used to find employee which will fail and/or no logging activity</para>
        /// 
        [TestMethod]
        public void FindEmployee_ExceptionTest1()
        {
           
            TheCompany.Container Cont = new TheCompany.Container();

            String input1 = "firstName";
            String input2 = "Fail";
            bool expected = false;
            bool actual = true;

            actual = Cont.FindAndDisplay(input1,input2);

            Assert.AreEqual(expected, actual, "Found Fake Employee");
        }




        ///
        /// <para><b>Test Identifier</b> - AddFullTimeEmployee_Normal1()</para>
        /// <para><b>Unique Identifier</b> - TC.C.AFTE.N1</para>
        /// <para><b>Description</b> - Method tests the regular use of the method, attempting to add new Fulltime Employee entry</para>
        /// <para><b>Method of execution</b> - Automatic</para>
        /// <para><b>Input data</b> - FullTimeEmployee</para>
        /// <para><b>Expected outputs</b> - The passed in FullTimeEmployee object added to the container and log it in a log file</para>
        /// <para><b>Observed outputs</b> - Test passed</para>
        /// <para><b>If Failed</b> - Displays failed message regarding the attempt to add an employee object and log it in a log file</para>
        /// 
        [TestMethod]
        public void AddFullTimeEmployee_NormalTest1(Employee newEmployee)
        {
            FulltimeEmployee ft = new FulltimeEmployee();
            TheCompany.Container Cont = new TheCompany.Container();

            bool expected = true;
            bool actual = false;

            actual = Cont.AddFullTimeEmployee(ft);

            Assert.AreEqual(expected, actual, "Did not add a new employee");

        }


        ///
        /// <para><b>Test Identifier</b> - AddPartTimeEmployee_Normal1()</para>
        /// <para><b>Unique Identifier</b> - TC.C.APTE.N1</para>
        /// <para><b>Description</b> - Method tests the regular use of the method, attempting to add new Parttime Employee entry</para>
        /// <para><b>Method of execution</b> - Automatic</para>
        /// <para><b>Input data</b> - PartTimeEmployee</para>
        /// <para><b>Expected outputs</b> - The passed in PartTimeEmployee object added to the container and log it in a log file</para>
        /// <para><b>Observed outputs</b> - Test passed</para>
        /// <para><b>If Failed</b> - Displays failed message regarding the attempt to add an employee object and log it in a log file</para>
        /// 
        [TestMethod]
        public void AddPartTimeEmployee_NormalTest1(Employee newEmployee)
        {
            ParttimeEmployee pt = new ParttimeEmployee();
            TheCompany.Container Cont = new TheCompany.Container();

            bool expected = true;
            bool actual = false;

            actual = Cont.AddPartTimeEmployee(pt);

            Assert.AreEqual(expected, actual, "Did not add a new employee");

        }

        ///
        /// <para><b>Test Identifier</b> - AddSeasonalEmployee_Normal1()</para>
        /// <para><b>Unique Identifier</b> - TC.C.ASE.N1</para>
        /// <para><b>Description</b> - Method tests the regular use of the method, attempting to add new Seasonal Employee entry</para>
        /// <para><b>Method of execution</b> - Automatic</para>
        /// <para><b>Input data</b> - PartTimeEmployee</para>
        /// <para><b>Expected outputs</b> - The passed in SeasonalEmployee object added to the container and log it in a log file</para>
        /// <para><b>Observed outputs</b> - Test passed</para>
        /// <para><b>If Failed</b> - Displays failed message regarding the attempt to add an employee object and log it in a log file</para>
        /// 
        [TestMethod]
        public void AddSeasonalEmployee_NormalTest1(Employee newEmployee)
        {
            SeasonalEmployee sn = new SeasonalEmployee();
            TheCompany.Container Cont = new TheCompany.Container();

            bool expected = true;
            bool actual = false;

            actual = Cont.AddSeasonalEmployee(sn);

            Assert.AreEqual(expected, actual, "Did not add a new employee");

        }

        ///
        /// <para><b>Test Identifier</b> - AddContractEmployee_Normal1()</para>
        /// <para><b>Unique Identifier</b> - TC.C.ACE.N1</para>
        /// <para><b>Description</b> - Method tests the regular use of the method, attempting to add new Contract Employee entry</para>
        /// <para><b>Method of execution</b> - Automatic</para>
        /// <para><b>Input data</b> - ContractEmployee</para>
        /// <para><b>Expected outputs</b> - The passed in ContractEmployee object added to the container and log it in a log file</para>
        /// <para><b>Observed outputs</b> - TestPased</para>
        /// <para><b>If Failed</b> - Displays failed message regarding the attempt to add an employee object and log it in a log file</para>
        /// 
        [TestMethod]
        public void AddContractEmployee_NormalTest1(Employee newEmployee)
        {
            ContractEmployee ct = new ContractEmployee();
            TheCompany.Container Cont = new TheCompany.Container();

            bool expected = true;
            bool actual = false;

            actual = Cont.AddContractEmployee(ct);

            Assert.AreEqual(expected, actual, "Did not add a new employee");

        }



    }
}
 
