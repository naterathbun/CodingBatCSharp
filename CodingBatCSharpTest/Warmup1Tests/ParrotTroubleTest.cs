using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodingBatCSharp.Warmup1;

namespace CodingBatCSharpTest.Warmup1Tests
{
    [TestClass]
    public class ParrotTroubleTest
    {
        [TestMethod]
        public void ParrotTrouble_true_6_returnTrue()
        {
            Assert.AreEqual(true, ParrotTrouble.ShowAnswer(true, 6));
        }
        [TestMethod]
        public void ParrotTrouble_true_7_returnFalse()
        {
            Assert.AreEqual(false, ParrotTrouble.ShowAnswer(true, 7));
        }
        [TestMethod]
        public void ParrotTrouble_false_6_returnFalse()
        {
            Assert.AreEqual(false, ParrotTrouble.ShowAnswer(false, 6));
        }

    }
}
