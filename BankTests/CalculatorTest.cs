using Bank;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankTests
{
    [TestFixture]
    class CalculatorTest
    {
        [TestCase]
        public void Test_Divide()
        {
            //Arrange
            int expected = 5;
            int numerator = 20;
            int denominator = 4;

            // Act
         int actual =   Calculator.Divide(numerator, denominator);

            // Assert
            NUnit.Framework.Assert.AreEqual(expected, actual);
        }
    }
}
