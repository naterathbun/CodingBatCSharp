using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodingBatCSharp.Warmup1;

namespace CodingBatCSharpTest.Warmup1Tests
{
    [TestClass]
    public class MonkeyTroubleTest
    {
        [TestMethod]
        public void MonkeyTrouble_aTrue_bTrue_true()
        {
            // Arrange
            bool testResult = MonkeyTrouble.ShowAnswer(true, true);
            // Act
            // Assert   
            Assert.AreEqual(true, testResult);
        }

        [TestMethod]
        public void MonkeyTrouble_aTrue_bFalse_False()
        {
            // Arrange
            bool testResult = MonkeyTrouble.ShowAnswer(true, false);
            // Act
            // Assert   
            Assert.AreEqual(false, testResult);
        }

        [TestMethod]
        public void MonkeyTrouble_aFalse_bTrue_false()
        {
            // Arrange
            bool testResult = MonkeyTrouble.ShowAnswer(false, true);
            // Act
            // Assert   
            Assert.AreEqual(false, testResult);
        }

        [TestMethod]
        public void MonkeyTrouble_aFalse_bFalse_true()
        {
            // Arrange
            bool testResult = MonkeyTrouble.ShowAnswer(false, false);
            // Act
            // Assert   
            Assert.AreEqual(true, testResult);
        }
    }
}
