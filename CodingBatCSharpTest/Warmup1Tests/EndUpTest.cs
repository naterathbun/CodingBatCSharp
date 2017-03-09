using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodingBatCSharp.Warmup1;

namespace CodingBatCSharpTest.Warmup1Tests
{
    [TestClass]
    public class EndUpTest
    {
        [TestMethod]
        public void EndUpTest_Hello_return_HeLLO()
        {
            Assert.AreEqual("HeLLO", EndUp.ShowAnswer("Hello"));
        }
        [TestMethod]
        public void EndUpTest_hithere_return_hithERE()
        {
            Assert.AreEqual("hi thERE", EndUp.ShowAnswer("hi there"));
        }
        [TestMethod]
        public void EndUpTest_hi_return_HI()
        {
            Assert.AreEqual("HI", EndUp.ShowAnswer("hi"));
        }
    }
}
