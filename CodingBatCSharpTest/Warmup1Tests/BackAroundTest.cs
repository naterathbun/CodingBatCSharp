using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodingBatCSharp.Warmup1;

namespace CodingBatCSharpTest.Warmup1Tests
{
    [TestClass]
    public class BackAroundTest
    {
        [TestMethod]
        public void BackAroundTest_str_cat_result_tcatt()
        {
            Assert.AreEqual("tcatt", BackAround.ShowAnswer("cat"));
        }
        [TestMethod]
        public void BackAroundTest_str_Hello_result_oHelloo()
        {
            Assert.AreEqual("oHelloo", BackAround.ShowAnswer("Hello"));
        }
        [TestMethod]
        public void BackAroundTest_str_a_result_aaa()
        {
            Assert.AreEqual("aaa", BackAround.ShowAnswer("a"));
        }


    }
}
