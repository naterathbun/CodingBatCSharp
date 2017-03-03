using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodingBatCSharp.Warmup1;

namespace CodingBatCSharpTest.Warmup1Tests
{
    [TestClass]
    public class FrontBackTest
    {
        [TestMethod]
        public void FrontBackTest_str_code_return_eodc()
        {
            Assert.AreEqual("eodc", FrontBack.ShowAnswer("code"));
        }
        [TestMethod]
        public void FrontBackTest_str_a_return_a()
        {
            Assert.AreEqual("a", FrontBack.ShowAnswer("a"));
        }
        [TestMethod]
        public void FrontBackTest_str_ab_return_ba()
        {
            Assert.AreEqual("ba", FrontBack.ShowAnswer("ab"));
        }


    }
}
