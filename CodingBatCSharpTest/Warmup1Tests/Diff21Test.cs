using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodingBatCSharp.Warmup1;

namespace CodingBatCSharpTest.Warmup1Tests
{
    [TestClass]
    public class Diff21Test
    {
        [TestMethod]
        public void Diff21Test_n19_return2()
        {
            Assert.AreEqual(2, Diff21.ShowAnswer(19));
        }
        [TestMethod]
        public void Diff21Test_n10_return11()
        {
            Assert.AreEqual(8, Diff21.ShowAnswer(25));
        }
        [TestMethod]
        public void Diff21Test_n21_return0()
        {
            Assert.AreEqual(0, Diff21.ShowAnswer(21));
        }
        [TestMethod]
        public void Diff21Test_n30_return18()
        {
            Assert.AreEqual(18, Diff21.ShowAnswer(30));
        }

    }
}
