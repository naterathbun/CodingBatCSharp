using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodingBatCSharp.Warmup1;

namespace CodingBatCSharpTest.Warmup1Tests
{
    [TestClass]
    public class Front22Test
    {
        [TestMethod]
        public void Front22Test_str_kitten_result_kikittenki()
        {
            Assert.AreEqual("kikittenki", Front22.ShowAnswer("kitten"));
        }
        [TestMethod]
        public void Front22Test_str_Ha_result_HaHaHa()
        {
            Assert.AreEqual("HaHaHa", Front22.ShowAnswer("Ha"));
        }
        [TestMethod]
        public void Front22Test_str_abc_result_ababcab()
        {
            Assert.AreEqual("ababcab", Front22.ShowAnswer("abc"));
        }
    }
}
