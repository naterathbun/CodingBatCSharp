using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodingBatCSharp.Warmup1;

namespace CodingBatCSharpTest.Warmup1Tests
{
    [TestClass]
    public class MonkeyTroubleTest
    {
        [TestMethod]
        public void MonkeyTroubleTest_aTrue_bTrue_resultTrue()
        {
            Assert.AreEqual(true, MonkeyTrouble.ShowAnswer(true,true));
        }
        [TestMethod]
        public void MonkeyTroubleTest_aTrue_bFalse_resultFalse()
        {
            Assert.AreEqual(false, MonkeyTrouble.ShowAnswer(true, false));
        }
        [TestMethod]
        public void MonkeyTroubleTest_aFalse_bTrue_resultFalse()
        {
            Assert.AreEqual(false, MonkeyTrouble.ShowAnswer(false, true));
        }
        [TestMethod]
        public void MonkeyTroubleTest_aFalse_bFalse_resultTrue()
        {
            Assert.AreEqual(true, MonkeyTrouble.ShowAnswer(false, false));
        }
    }
}
