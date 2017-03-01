using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodingBatCSharp.Warmup1;

namespace CodingBatCSharpTest.Warmup1Tests
{
    [TestClass]
    public class Near100Test
    {
        [TestMethod]
        public void Near100Test_n93_returnTrue()
        {
            Assert.AreEqual(true, Near100.ShowAnswer(93));
        }
        [TestMethod]
        public void Near100Test_n90_returnTrue()
        {
            Assert.AreEqual(true, Near100.ShowAnswer(90));
        }
        [TestMethod]
        public void Near100Test_n89_returnFalse()
        {
            Assert.AreEqual(false, Near100.ShowAnswer(89));
        }
    }
}
