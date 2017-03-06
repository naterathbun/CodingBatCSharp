using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingBatCSharpTest.Warmup1Tests
{
    [TestClass]
    public class HasTeenTest
    {
        [TestMethod]
        public void HasTeenTest_13_20_10_return_true()
        {
            Assert.AreEqual(true, HasTeen.ShowAnswer(13, 20, 10));
        }
        [TestMethod]
        public void HasTeenTest_20_19_10_return_true()
        {
            Assert.AreEqual(true, HasTeen.ShowAnswer(20, 19, 10));
        }
        [TestMethod]
        public void HasTeenTest_20_10_13_return_true()
        {
            Assert.AreEqual(true, HasTeen.ShowAnswer(20, 10, 13));
        }
        [TestMethod]
        public void HasTeenTest_20_35_neg1_return_false()
        {
            Assert.AreEqual(false, HasTeen.ShowAnswer(20, 35, -1));
        }
    }
}
