using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodingBatCSharp.Warmup2;

namespace CodingBatCSharpTest.Warmup2Tests
{
    [TestClass]
    public class ArrayCount9Test
    {
        [TestMethod]
        public void ArrayCount9Test_129_result_1()
        {
            Assert.AreEqual(1,ArrayCount9.ShowAnswer(new int[] { 1, 2, 9 }));
        }
        [TestMethod]
        public void ArrayCount9Test_199_result_2()
        {
            Assert.AreEqual(2, ArrayCount9.ShowAnswer(new int[] { 1, 9, 9 }));
        }
        [TestMethod]
        public void ArrayCount9Test_125_result_0()
        {
            Assert.AreEqual(0, ArrayCount9.ShowAnswer(new int[] { 1, 2, 5 }));
        }
    }
}
