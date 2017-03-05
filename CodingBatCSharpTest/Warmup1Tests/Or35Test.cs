using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodingBatCSharp.Warmup1;

namespace CodingBatCSharpTest
{
    [TestClass]
    public class Or35Test
    {
        [TestMethod]
        public void Or35Test_n_3_result_true()
        {
            Assert.AreEqual(true, Or35.ShowAnswer(3));
        }
        [TestMethod]
        public void Or35Test_n_10_result_true()
        {
            Assert.AreEqual(true, Or35.ShowAnswer(10));
        }
        [TestMethod]
        public void Or35Test_n_8_result_false()
        {
            Assert.AreEqual(false, Or35.ShowAnswer(8));
        }
    }
}
