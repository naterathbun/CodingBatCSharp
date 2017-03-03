using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodingBatCSharp.Warmup1;

namespace CodingBatCSharpTest.Warmup1Tests
{
    [TestClass]
    public class Front3Test
    {
        [TestMethod]
        public void Front3Test_str__Java_result_JavJavJav()
        {
            Assert.AreEqual("JavJavJav", Front3.ShowAnswer("Java"));
        }
        [TestMethod]
        public void Front3Test_str__Chocolate_result_ChoChoCho()
        {
            Assert.AreEqual("ChoChoCho", Front3.ShowAnswer("Chocolate"));
        }
        [TestMethod]
        public void Front3Test_str__abc_result_abcabcabc()
        {
            Assert.AreEqual("abcabcabc", Front3.ShowAnswer("abc"));
        }

    }
}
