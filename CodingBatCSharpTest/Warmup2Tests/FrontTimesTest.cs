using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodingBatCSharp.Warmup2;

namespace CodingBatCSharpTest.Warmup2Tests
{
    [TestClass]
    public class FrontTimesTest
    {
        [TestMethod]
        public void FrontTimesTest_Chocolate_2_result_ChoCho()
        {
            Assert.AreEqual("ChoCho", FrontTimes.ShowAnswer("Chocolate", 2));
        }

        [TestMethod]
        public void FrontTimesTest_Chocolate_3_result_ChoChoCho()
        {
            Assert.AreEqual("ChoChoCho", FrontTimes.ShowAnswer("Chocolate", 3));
        }

        [TestMethod]
        public void FrontTimesTest_Abc_3_result_AbcAbcAbc()
        {
            Assert.AreEqual("AbcAbcAbc", FrontTimes.ShowAnswer("Abc", 3));
        }

    }
}
