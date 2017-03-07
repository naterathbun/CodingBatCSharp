using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodingBatCSharp.Warmup1;

namespace CodingBatCSharpTest.Warmup1Tests
{
    [TestClass]
    public class DelDelTest
    {
        [TestMethod]
        public void DelDelTest_str_adelbc_result_abc()
        {
            Assert.AreEqual("abc", DelDel.ShowAnswer("adelbc"));
        }
        [TestMethod]
        public void DelDelTest_str_adelHello_result_aHello()
        {
            Assert.AreEqual("aHello", DelDel.ShowAnswer("adelHello"));
        }
        [TestMethod]
        public void DelDelTest_str_adedbc_result_adedbc()
        {
            Assert.AreEqual("adedbc", DelDel.ShowAnswer("adedbc"));
        }
    }
}
