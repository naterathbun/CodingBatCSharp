using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodingBatCSharp.Warmup2;

namespace CodingBatCSharpTest.Warmup2Tests
{
    [TestClass]
    public class StringMatchTest
    {
        [TestMethod]
        public void StringMatchTest_xxcaazz_xxbaaz_result_3()
        {
            Assert.AreEqual(3, StringMatch.ShowAnswer("xxcaazz", "xxbaaz"));
        }
        [TestMethod]
        public void StringMatchTest_abc_abc_result_2()
        {
            Assert.AreEqual(2, StringMatch.ShowAnswer("abc", "abc"));
        }
        [TestMethod]
        public void StringMatchTest_abc_axc_result_0()
        {
            Assert.AreEqual(0, StringMatch.ShowAnswer("abc", "axc"));
        }
    }
}
