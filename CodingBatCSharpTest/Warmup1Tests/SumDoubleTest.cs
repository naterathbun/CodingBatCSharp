using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodingBatCSharp.Warmup1;

namespace CodingBatCSharpTest.Warmup1Tests
{
    [TestClass]
    public class SumDoubleTest
    {
        [TestMethod]
        public void SumDoubleTest_a1_b2_return3()
        {
            Assert.AreEqual(3,SumDouble.ShowAnswer(1, 2));
        }
        [TestMethod]
        public void SumDoubleTest_aNeg5_b7_return2()
        {
            Assert.AreEqual(2, SumDouble.ShowAnswer(-5, 7));
        }
        [TestMethod]
        public void SumDoubleTest_a5_b5_return20()
        {
            Assert.AreEqual(20, SumDouble.ShowAnswer(5, 5));
        }

    }
}
