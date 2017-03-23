using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodingBatCSharp.Warmup2;

namespace CodingBatCSharpTest.Warmup2Tests
{
    [TestClass]
    public class ArrayFront9Test
    {
        [TestMethod]
        public void ArrayFront9_12934_result_true()
        {
            Assert.AreEqual(true, ArrayFront9.ShowAnswer(new int[] { 1, 2, 9, 3, 4 }));
        }
        [TestMethod]
        public void ArrayFront9_12349_result_false()
        {
            Assert.AreEqual(false, ArrayFront9.ShowAnswer(new int[] { 1, 2, 3, 4, 9 }));
        }
        [TestMethod]
        public void ArrayFront9_12345_result_false()
        {
            Assert.AreEqual(false, ArrayFront9.ShowAnswer(new int[] { 1, 2, 3, 4, 5}));
        }
    }
}
