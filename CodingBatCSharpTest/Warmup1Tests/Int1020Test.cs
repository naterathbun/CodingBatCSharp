using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodingBatCSharp.Warmup1;

namespace CodingBatCSharpTest.Warmup1Tests
{
    [TestClass]
    public class Int1020Test
    {
        [TestMethod]
        public void Int1020Test_12_99_result_true()
        {
            Assert.AreEqual(true, Int1020.ShowAnswer(12, 99));
        }
        [TestMethod]
        public void Int1020Test_21_12_result_true()
        {
            Assert.AreEqual(true, Int1020.ShowAnswer(21, 12));
        }
        [TestMethod]
        public void Int1020Test_8_99_result_false()
        {
            Assert.AreEqual(false, Int1020.ShowAnswer(8, 99));
        }
    }
}
