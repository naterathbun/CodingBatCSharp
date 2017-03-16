using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodingBatCSharp.Warmup2;

namespace CodingBatCSharpTest.Warmup2Tests
{
    [TestClass]
    public class Last2Test
    {
        [TestMethod]
        public void Last2Test_hixxhi_result_1()
        {
            Assert.AreEqual(1, Last2.ShowAnswer("hixxhi"));
        }
        [TestMethod]
        public void Last2Test_xaxxaxaxx_result_1()
        {
            Assert.AreEqual(1, Last2.ShowAnswer("xaxxaxaxx"));
        }
        [TestMethod]
        public void Last2Test_axxxaaxx_result_2()
        {
            Assert.AreEqual(2, Last2.ShowAnswer("axxxaaxx"));
        }
    }
}
