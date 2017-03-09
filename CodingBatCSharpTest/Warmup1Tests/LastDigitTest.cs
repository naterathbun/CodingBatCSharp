using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodingBatCSharp.Warmup1;

namespace CodingBatCSharpTest.Warmup1Tests
{
    [TestClass]
    public class LastDigitTest
    {
        [TestMethod]
        public void LastDigitTest_7_17_return_true()
        {
            Assert.AreEqual(true, LastDigit.ShowAnswer(7, 17));
        }
        [TestMethod]
        public void LastDigitTest_6_17_return_false()
        {
            Assert.AreEqual(false, LastDigit.ShowAnswer(6, 17));
        }
        [TestMethod]
        public void LastDigitTest_3_113_return_true()
        {
            Assert.AreEqual(true, LastDigit.ShowAnswer(3, 113));
        }

    }
}
