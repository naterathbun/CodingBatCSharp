using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodingBatCSharp.Warmup1;

namespace CodingBatCSharpTest.Warmup1Tests
{
    [TestClass]
    public class StartOzTest
    {
        [TestMethod]
        public void StartOz_str_ozymandias_return_oz()
        {
            Assert.AreEqual("oz", StartOz.ShowAnswer("ozymandias"));
        }
        [TestMethod]
        public void StartOz_str_bzoo_return_z()
        {
            Assert.AreEqual("z", StartOz.ShowAnswer("bzoo"));
        }
        [TestMethod]
        public void StartOz_str_oxx_return_o()
        {
            Assert.AreEqual("o", StartOz.ShowAnswer("oxx"));
        }
        [TestMethod]
        public void StartOz_str_bacon_return_empty()
        {
            Assert.AreEqual("", StartOz.ShowAnswer("bacon"));
        }


    }
}
