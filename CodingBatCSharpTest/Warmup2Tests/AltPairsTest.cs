using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodingBatCSharp.Warmup2;

namespace CodingBatCSharpTest.Warmup2Tests
{
    [TestClass]
    public class AltPairsTest
    {
        [TestMethod]
        public void AltPairsTest_kitten_result_kien()
        {
            Assert.AreEqual("kien", AltPairs.ShowAnswer("kitten"));
        }
        [TestMethod]
        public void AltPairsTest_Chocolate_result_Chole()
        {
            Assert.AreEqual("Chole", AltPairs.ShowAnswer("Chocolate"));
        }
        [TestMethod]
        public void AltPairsTest_CodingHorror_result_Congrr()
        {
            Assert.AreEqual("Congrr", AltPairs.ShowAnswer("CodingHorror"));
        }
    }
}
