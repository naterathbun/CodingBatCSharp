using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodingBatCSharp.Warmup2;

namespace CodingBatCSharpTest.Warmup2Tests
{
    [TestClass]
    public class DoubleXTest
    {
        [TestMethod]
        public void DoubleXTest_axxbb_return_true()
        {
            Assert.AreEqual(true, DoubleX.ShowAnswer("axxbb"));
        }
        [TestMethod]
        public void DoubleXTest_axaxax_return_false()
        {
            Assert.AreEqual(false, DoubleX.ShowAnswer("axaxax"));
        }
        [TestMethod]
        public void DoubleXTest_xxxxx_return_true()
        {
            Assert.AreEqual(true, DoubleX.ShowAnswer("xxxxx"));
        }
    }
}
