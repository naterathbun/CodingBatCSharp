using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodingBatCSharp.Warmup1;

namespace CodingBatCSharpTest.Warmup1Tests
{
    [TestClass]
    public class IntMaxTest
    {
        [TestMethod]
        public void IntMaxTest_1_2_3_return_3()
        {
            Assert.AreEqual(3, IntMax.ShowAnswer(1, 2, 3));
        }
        [TestMethod]
        public void IntMaxTest_1_3_2_return_3()
        {
            Assert.AreEqual(3, IntMax.ShowAnswer(1, 3, 2));
        }
        [TestMethod]
        public void IntMaxTest_3_2_1_return_3()
        {
            Assert.AreEqual(3, IntMax.ShowAnswer(3, 2, 1));
        }

    }
}
