using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodingBatCSharp.Warmup1;

namespace CodingBatCSharpTest.Warmup1Tests
{
    [TestClass]
    public class MissingCharTest
    {
        [TestMethod]
        public void MissingCharTest_strkitten_int1_returnktten()
        {
            Assert.AreEqual("ktten", MissingChar.ShowAnswer("kitten", 1));
        }
        [TestMethod]
        public void MissingCharTest_strkitten_int0_returnitten()
        {
            Assert.AreEqual("itten", MissingChar.ShowAnswer("kitten", 0));
        }
        [TestMethod]
        public void MissingCharTest_strkitten_int4_returnkittn()
        {
            Assert.AreEqual("kittn", MissingChar.ShowAnswer("kitten", 4));
        }
        [TestMethod]
        public void MissingCharTest_strkitten_int5_returnkitte()
        {
            Assert.AreEqual("kitte", MissingChar.ShowAnswer("kitten", 5));
        }
    }
}
