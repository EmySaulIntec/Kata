using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RomanNumeralsLibrary;

namespace RomanNumeralsTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ONE_TO_I()
        {
            RomanConversor romanConversor = new RomanConversor();

            // Input
            int number = 1;
            string experatedValue = "I";

            // Test
           string result = romanConversor.Convert(number);

            // Assert
            Assert.AreEqual(experatedValue, result);
        }

        [TestMethod]
        public void TEN_TO_X()
        {
            RomanConversor romanConversor = new RomanConversor();

            // Input
            int number = 10;
            string experatedValue = "X";

            // Test
            string result = romanConversor.Convert(number);

            // Assert
            Assert.AreEqual(experatedValue, result);
        }

        [TestMethod]
        public void SEVEN_TO_VII()
        {
            RomanConversor romanConversor = new RomanConversor();

            // Input
            int number = 7;
            string experatedValue = "VII";

            // Test
            string result = romanConversor.Convert(number);

            // Assert
            Assert.AreEqual(experatedValue, result);
        }
    }
}
