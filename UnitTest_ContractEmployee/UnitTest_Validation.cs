using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text;
using System.Threading.Tasks;
using Supporting;

namespace UnitTest_AllEmployees
{
    [TestClass]
    class UnitTest_Validation
    {

        ///
        /// <para><b>Test Identifier</b> - ValidateSIN_NormalTest1()</para>
        /// <para><b>Unique Identifier</b> - AE.SE.VS.N.1</para>
        /// <para><b>Description</b> - Method tests the regular use of the method, Attempting to validate a normal SIN</para>
        /// <para><b>Method of execution</b> - Automatic</para>
        /// <para><b>Input data</b> - "193 456 787"</para>
        /// <para><b>Expected outputs</b> - "193 456 787"</para>
        /// <para><b>Observed outputs</b> - "193 456 787"</para>
        /// <para><b>If Failed</b> - Displays failed message regarding setting the variable:Did not accept valid SIN</para>
        /// 
        [TestMethod]
        public void ValidateSIN_NormalTest1()
        {
            Validation val = new Validation();
            string input = "193 456 787";
            bool expected = true;
            bool actual = false;

            val.sin(input);

            Assert.AreEqual(expected, actual, "Did not accept valid sin");
        }

        ///
        /// <para><b>Test Identifier</b> - ValidateSIN_ExceptionTest1()</para>
        /// <para><b>Unique Identifier</b> - AE.SE.VS.E.1</para>
        /// <para><b>Description</b> - Method tests the improper use of the method, Attempting to validate a false SIN</para>
        /// <para><b>Method of execution</b> - Automatic</para>
        /// <para><b>Input data</b> - "123 123 123"</para>
        /// <para><b>Expected outputs</b> - "Error message"</para>
        /// <para><b>Observed outputs</b> - "Error message stating: Did not accept Invalid sin"</para>
        /// <para><b>If Failed</b> - Improper SIN number will pass</para>
        /// 
        [TestMethod]
        public void ValidateSin_ExepctionTest1()
        {
            Validation val = new Validation();
            string input = "123 123 123";
            bool expected = true;
            bool actual = false;

            val.sin(input);
            Assert.AreEqual(expected, actual, "Did not accept Invalid sin");
        }







    }
}
