using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodingBatCSharp.Warmup2;

namespace CodingBatCSharpTest.Warmup2Tests
{
    [TestClass]
    public class StringXTest
    {
        [TestMethod]
        public void StringXTest_xxHxix_result_xHix()
        {
            Assert.AreEqual("xHix", StringX.ShowAnswer("xxHxix"));
        }
        [TestMethod]
        public void StringXTest_abxxxcd_result_abcd()
        {
            Assert.AreEqual("abcd", StringX.ShowAnswer("abxxxcd"));
        }
        [TestMethod]
        public void StringXTest_xabxxxcdx_result_xabcdx()
        {
            Assert.AreEqual("xabcdx", StringX.ShowAnswer("xabxxxcdx"));
        }
    }
}
