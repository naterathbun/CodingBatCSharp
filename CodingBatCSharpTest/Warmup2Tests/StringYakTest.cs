using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodingBatCSharp.Warmup2;

namespace CodingBatCSharpTest.Warmup2Tests
{
    [TestClass]
    public class StringYakTest
    {
        [TestMethod]
        public void StringYakTest_yakpak_result_pak()
        {
            Assert.AreEqual("pak", StringYak.ShowAnswer("yakpak"));
        }
        [TestMethod]
        public void StringYakTest_pakyak_result_pak()
        {
            Assert.AreEqual("pak", StringYak.ShowAnswer("pakyak"));
        }
        [TestMethod]
        public void StringYakTest_yak123ya_result_123ya()
        {
            Assert.AreEqual("123ya", StringYak.ShowAnswer("yak123ya"));
        }
    }
}
