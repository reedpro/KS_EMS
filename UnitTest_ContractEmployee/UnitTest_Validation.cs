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
    }
}
