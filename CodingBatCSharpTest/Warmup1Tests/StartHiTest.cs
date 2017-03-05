using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodingBatCSharp.Warmup1;

namespace CodingBatCSharpTest.Warmup1Tests
{
    [TestClass]
    public class StartHiTest
    {
        [TestMethod]
        public void StartHiTest_str_hithere_result_true()
        {
            Assert.AreEqual(true, StartHi.ShowAnswer("hi there"));
        }
        [TestMethod]
        public void StartHiTest_str_hi_result_true()
        {
            Assert.AreEqual(true, StartHi.ShowAnswer("hi"));
        }
        [TestMethod]
        public void StartHiTest_str_hellohi_result_false()
        {
            Assert.AreEqual(false, StartHi.ShowAnswer("hello hi"));
        }


    }
}
