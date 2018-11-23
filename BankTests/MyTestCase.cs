using Bank;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankTests
{
    [TestFixture]
    class MyTestCase
    {
        [TestCase]
        public void Add()
        {
            MyMath math = new MyMath();
            Assert.AreEqual(31, math.Add(20, 11));
        }
        [TestCase]
        public void Sub()
        {
            MyMath math = new MyMath();
            Assert.AreEqual(13, math.Sub(21, 9));
        }
    }
}
