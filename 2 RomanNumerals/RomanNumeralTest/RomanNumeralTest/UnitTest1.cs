using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RomanNumeralLibrary;

namespace RomanNumeralTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TRANSLATE_1_TO_I()
        {
            Conversor conversor = new Conversor();

            // Input
            int number = 1;
            string experatedValue = "I";

            // Test
            string result = conversor.Convert(number);

            // Assert
            Assert.AreEqual(experatedValue, result);
        }


        [TestMethod]
        public void TRANSLATE_10_TO_X()
        {
            Conversor conversor = new Conversor();

            // Input
            int number = 10;
            string experatedValue = "X";

            // Test
            string result = conversor.Convert(number);

            // Assert
            Assert.AreEqual(experatedValue, result);
        }

        [TestMethod]
        public void TRANSLATE_7_TO_VII()
        {
            Conversor conversor = new Conversor();

            // Input
            int number = 7;
            string experatedValue = "VII";

            // Test
            string result = conversor.Convert(number);

            // Assert
            Assert.AreEqual(experatedValue, result);
        }
    }
}
