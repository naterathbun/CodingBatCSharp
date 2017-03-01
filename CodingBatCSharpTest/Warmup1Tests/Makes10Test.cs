using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodingBatCSharp.Warmup1;

namespace CodingBatCSharpTest.Warmup1Tests
{
    [TestClass]
    public class Makes10Test
    {
        [TestMethod]
        public void Makes10_a5_b2_returnFalse()
        {
            Assert.AreEqual(false, Makes10.ShowAnswer(5, 2));
        }
        [TestMethod]
        public void Makes10_a10_b2_returnTrue()
        {
            Assert.AreEqual(true, Makes10.ShowAnswer(10, 2));
        }
        [TestMethod]
        public void Makes10_a5_b10_returnTrue()
        {
            Assert.AreEqual(true, Makes10.ShowAnswer(5, 10));
        }
        [TestMethod]
        public void Makes10_a6_b4_returnTrue()
        {
            Assert.AreEqual(true, Makes10.ShowAnswer(6, 4));
        }


    }
}
