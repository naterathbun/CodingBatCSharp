using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodingBatCSharp.Warmup1;

namespace CodingBatCSharpTest.Warmup1Tests
{
    [TestClass]
    public class Max1020Test
    {
        [TestMethod]
        public void Max1020Test_11_19_return_19()
        {
            Assert.AreEqual(19, Max1020.ShowAnswer(11, 19));
        }
        [TestMethod]
        public void Max1020Test_19_11_return_19()
        {
            Assert.AreEqual(19, Max1020.ShowAnswer(19, 11));
        }
        [TestMethod]
        public void Max1020Test_11_9_return_11()
        {
            Assert.AreEqual(11, Max1020.ShowAnswer(11, 9));
        }
        [TestMethod]
        public void Max1020Test_4_50_return_0()
        {
            Assert.AreEqual(0, Max1020.ShowAnswer(4, 50));
        }
    }
}
