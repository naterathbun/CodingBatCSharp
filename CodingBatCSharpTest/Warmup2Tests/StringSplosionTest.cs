using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodingBatCSharp.Warmup2;

namespace CodingBatCSharpTest.Warmup2Tests
{
    [TestClass]
    public class StringSplosionTest
    {
        [TestMethod]
        public void StringSplosionTest_Code_Result_CCoCodCode()
        {
            Assert.AreEqual("CCoCodCode", StringSplosion.ShowAnswer("Code"));
        }
        [TestMethod]
        public void StringSplosionTest_abc_Result_aababc()
        {
            Assert.AreEqual("aababc", StringSplosion.ShowAnswer("abc"));
        }
        [TestMethod]
        public void StringSplosionTest_ab_Result_aab()
        {
            Assert.AreEqual("aab", StringSplosion.ShowAnswer("ab"));
        }
    }
}
