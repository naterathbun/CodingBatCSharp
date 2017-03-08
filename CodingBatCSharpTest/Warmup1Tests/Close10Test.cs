using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodingBatCSharp.Warmup1;

namespace CodingBatCSharpTest.Warmup1Tests
{
    [TestClass]
    public class Close10Test
    {
        [TestMethod]
        public void Close10Test_8_13_return_8()
        {
            Assert.AreEqual(8, Close10.ShowAnswer(8, 13));
        }
        [TestMethod]
        public void Close10Test_13_8_return_8()
        {
            Assert.AreEqual(8, Close10.ShowAnswer(13, 8));
        }
        [TestMethod]
        public void Close10Test_13_7_return_0()
        {
            Assert.AreEqual(0, Close10.ShowAnswer(13, 7));
        }
    }
}
