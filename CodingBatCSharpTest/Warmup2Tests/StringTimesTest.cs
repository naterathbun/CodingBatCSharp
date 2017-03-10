using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodingBatCSharp.Warmup2;

namespace CodingBatCSharpTest.Warmup2Tests
{
    [TestClass]
    public class StringTimesTest
    {
        [TestMethod]
        public void StringTimesTest_Hi_2_result_HiHi()
        {
            Assert.AreEqual("HiHi", StringTimes.ShowAnswer("Hi", 2));
        }

        [TestMethod]
        public void StringTimesTest_Hi_3_result_HiHiHi()
        {
            Assert.AreEqual("HiHiHi", StringTimes.ShowAnswer("Hi", 3));
        }

        [TestMethod]
        public void StringTimesTest_Hi_1_result_Hi()
        {
            Assert.AreEqual("Hi", StringTimes.ShowAnswer("Hi", 1));
        }
    }
}
