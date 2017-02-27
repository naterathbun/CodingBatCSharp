using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodingBatCSharp.Warmup1;


namespace CodingBatCSharpTest
{
    [TestClass]
    public class SleepInTest
    {
        [TestMethod]
        public void SleepIn_Weekday_Vacation_True()
        {
            // Arrange
            bool testResult = SleepIn.ShowAnswer(true, true);
            // Act
            // Assert   
            Assert.AreEqual(true, testResult);
        }

        [TestMethod]
        public void SleepIn_Weekday_NoVacation_False()
        {
            // Arrange
            bool testResult = SleepIn.ShowAnswer(true, false);
            // Act
            // Assert   
            Assert.AreEqual(false, testResult);
        }

        [TestMethod]
        public void SleepIn_NoWeekday_Vacation_True()
        {
            // Arrange
            bool testResult = SleepIn.ShowAnswer(false, true);
            // Act
            // Assert   
            Assert.AreEqual(true, testResult);
        }

        [TestMethod]
        public void SleepIn_NoWeekday_NoVacation_True()
        {
            // Arrange
            bool testResult = SleepIn.ShowAnswer(false, false);
            // Act
            // Assert   
            Assert.AreEqual(true, testResult);
        }


    }
}
