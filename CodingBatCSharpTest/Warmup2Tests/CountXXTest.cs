using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodingBatCSharp.Warmup2;

namespace CodingBatCSharpTest
{
    [TestClass]
    public class CountXXTest
    {
        [TestMethod]
        public void CountXXTest_abcxx_return_1()
        {
            Assert.AreEqual(1, CountXX.ShowAnswer("abcxx"));
        }
        [TestMethod]
        public void CountXXTest_xxx_return_2()
        {
            Assert.AreEqual(2, CountXX.ShowAnswer("xxx"));
        }
        [TestMethod]
        public void CountXXTest_xxxx_return_3()
        {
            Assert.AreEqual(3, CountXX.ShowAnswer("xxxx"));
        }
    }
}
