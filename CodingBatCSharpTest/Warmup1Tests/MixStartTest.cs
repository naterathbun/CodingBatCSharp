using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodingBatCSharp.Warmup1;

namespace CodingBatCSharpTest.Warmup1Tests
{
    [TestClass]
    public class MixStartTest
    {
        [TestMethod]
        public void MixStartTest_str_mixsnacks_return_true()
        {
            Assert.AreEqual(true, MixStart.ShowAnswer("mix snacks"));
        }
        [TestMethod]
        public void MixStartTest_str_pixsnacks_return_true()
        {
            Assert.AreEqual(true, MixStart.ShowAnswer("pix snacks"));
        }
        [TestMethod]
        public void MixStartTest_str_pizsnacks_return_false()
        {
            Assert.AreEqual(false, MixStart.ShowAnswer("piz snacks"));
        }

    }
}
