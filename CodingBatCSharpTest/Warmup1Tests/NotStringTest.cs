using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodingBatCSharp.Warmup1;

namespace CodingBatCSharpTest.Warmup1Tests
{
    [TestClass]
    public class NotStringTest
    {
        [TestMethod]
        public void NotStringTest_strBacon_returnNotBacon()
        {
            Assert.AreEqual("Not Bacon", NotString.ShowAnswer("Bacon"));
        }
        [TestMethod]
        public void NotStringTest_strNotBacon_returnNotBacon()
        {
            Assert.AreEqual("Not Bacon", NotString.ShowAnswer("Not Bacon"));
        }
    }
}
