using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodingBatCSharp.Warmup1;

namespace CodingBatCSharpTest.Warmup1Tests
{
    [TestClass]
    public class IcyHotTest
    {
        [TestMethod]
        public void IcyHotTest_120_neg1_true()
        {
            Assert.AreEqual(true, IcyHot.ShowAnswer(120, -1));
        }
        [TestMethod]
        public void IcyHotTest_neg1_120_true()
        {
            Assert.AreEqual(true, IcyHot.ShowAnswer(-1, 120));
        }
        [TestMethod]
        public void IcyHotTest_2_120_false()
        {
            Assert.AreEqual(false, IcyHot.ShowAnswer(2, 120));
        }
    }
}
