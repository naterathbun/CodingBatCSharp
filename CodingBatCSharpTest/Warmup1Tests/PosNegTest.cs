using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodingBatCSharp.Warmup1;

namespace CodingBatCSharpTest.Warmup1Tests
{
    [TestClass]
    public class PosNegTest
    {
        [TestMethod]
        public void PosNegTest_a5_bneg5_negativeFalse_resultTrue()
        {
            Assert.AreEqual(true, PosNeg.ShowAnswer(5,-5,false));
        }
        [TestMethod]
        public void PosNegTest_aneg5_b5_negativeFalse_resultTrue()
        {
            Assert.AreEqual(true, PosNeg.ShowAnswer(-5, 5, false));
        }
        [TestMethod]
        public void PosNegTest_a5_b5_negativeFalse_resultFalse()
        {
            Assert.AreEqual(false, PosNeg.ShowAnswer(5, 5, false));
        }
        [TestMethod]
        public void PosNegTest_aneg5_bneg5_negativeFalse_resultFalse()
        {
            Assert.AreEqual(false, PosNeg.ShowAnswer(-5, -5, false));
        }
        [TestMethod]
        public void PosNegTest_a5_bneg5_negativeTrue_resultFalse()
        {
            Assert.AreEqual(false, PosNeg.ShowAnswer(5, -5, true));
        }
        [TestMethod]
        public void PosNegTest_aneg5_bneg5_negativeTrue_resultTrue()
        {
            Assert.AreEqual(true, PosNeg.ShowAnswer(-5, -5, true));
        }
    }
}
