using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodingBatCSharp.Warmup2;

namespace CodingBatCSharpTest.Warmup2Tests
{
    [TestClass]
    public class StringBitsTest
    {
        [TestMethod]
        public void StringBitsTest_Hello_result_Hlo()
        {
            Assert.AreEqual("Hlo", StringBits.ShowAnswer("Hello"));
        }
        [TestMethod]
        public void StringBitsTest_Hi_result_H()
        {
            Assert.AreEqual("H", StringBits.ShowAnswer("Hi"));
        }
        [TestMethod]
        public void StringBitsTest_Hello_result_Heeololeo()
        {
            Assert.AreEqual("Hello", StringBits.ShowAnswer("Heeololeo"));
        }
    }
}
