using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodingBatCSharp.Warmup1;

namespace CodingBatCSharpTest.Warmup1Tests
{
    [TestClass]
    public class LoneTeenTest
    {
        [TestMethod]
        public void LoneTeenTest_13_99_return_true()
        {
            Assert.AreEqual(true, LoneTeen.ShowAnswer(13, 99));
        }
        [TestMethod]
        public void LoneTeenTest_13_19_return_false()
        {
            Assert.AreEqual(false, LoneTeen.ShowAnswer(13, 19));
        }
        [TestMethod]
        public void LoneTeenTest_100_19_return_true()
        {
            Assert.AreEqual(true, LoneTeen.ShowAnswer(100, 19));
        }

    }
}
