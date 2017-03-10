using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodingBatCSharp.Warmup1;

namespace CodingBatCSharpTest.Warmup1Tests
{
    [TestClass]
    public class EveryNthTest
    {
        [TestMethod]
        public void EveryNthTest_Miracle_2_return_Mrce()
        {
            Assert.AreEqual("Mrce", EveryNth.ShowAnswer("Miracle", 2));
        }
        [TestMethod]
        public void EveryNthTest_abcdefg_2_return_aceg()
        {
            Assert.AreEqual("aceg", EveryNth.ShowAnswer("abcdefg", 2));
        }
        [TestMethod]
        public void EveryNthTest_abcdefg_3_return_adg()
        {
            Assert.AreEqual("adg", EveryNth.ShowAnswer("abcdefg", 3));
        }
    }
}
