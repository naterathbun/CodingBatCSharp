using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodingBatCSharp.Warmup2;

namespace CodingBatCSharpTest.Warmup2Tests
{
    [TestClass]
    public class Array123Test
    {
        [TestMethod]
        public void Array123Test_11231_true()
        {
            Assert.AreEqual(true, Array123.ShowAnswer(new int[] { 1, 1, 2, 3, 1 }));
        }
        [TestMethod]
        public void Array123Test_11241_false()
        {
            Assert.AreEqual(false, Array123.ShowAnswer(new int[] { 1, 1, 2, 4, 1 }));
        }
        [TestMethod]
        public void Array123Test_112123_true()
        {
            Assert.AreEqual(true, Array123.ShowAnswer(new int[] { 1, 1, 2, 1, 2, 3 }));
        }
    }
}
