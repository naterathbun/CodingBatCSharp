using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodingBatCSharp.Warmup1;

namespace CodingBatCSharpTest.Warmup1Tests
{
    [TestClass]
    public class In3050Test
    {
        [TestMethod]
        public void In3050Test_30_31_return_true()
        {
            Assert.AreEqual(true, In3050.ShowAnswer(30, 31));
        }
        [TestMethod]
        public void In3050Test_30_41_return_false()
        {
            Assert.AreEqual(false, In3050.ShowAnswer(30, 41));
        }
        [TestMethod]
        public void In3050Test_40_50_return_true()
        {
            Assert.AreEqual(true, In3050.ShowAnswer(40, 50));
        }


    }
}
