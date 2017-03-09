using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodingBatCSharp.Warmup1;

namespace CodingBatCSharpTest.Warmup1Tests
{
    [TestClass]
    public class StringETest
    {
        [TestMethod]
        public void StringETest_Hello_return_true()
        {
            Assert.AreEqual(true, StringE.ShowAnswer("Hello"));
        }
        [TestMethod]
        public void StringETest_Heelle_return_true()
        {
            Assert.AreEqual(true, StringE.ShowAnswer("Heelle"));
        }
        [TestMethod]
        public void StringETest_Heelele_return_false()
        {
            Assert.AreEqual(false, StringE.ShowAnswer("Heelele"));
        }
        [TestMethod]
        public void StringETest_bacon_return_false()
        {
            Assert.AreEqual(false, StringE.ShowAnswer("bacon"));
        }


    }
}
