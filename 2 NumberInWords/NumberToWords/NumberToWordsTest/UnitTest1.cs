using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NumberToWords;

namespace NumberToWordsTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CONVERT_1_to_ONE()
        {
            WordConversor wordConversor = new WordConversor();

            // input
            int number = 1;
            string experatedValue = "One";

            // Test
            string result = wordConversor.Convert(number);

            // Assert
            Assert.AreEqual(experatedValue, result);
        }

        [TestMethod]
        public void CONVERT_60_to_Sixty()
        {
            WordConversor wordConversor = new WordConversor();

            // input
            int number = 60;
            string experatedValue = "Sixty".ToUpper();

            // Test
            string result = wordConversor.Convert(number).ToUpper();

            // Assert
            Assert.AreEqual(experatedValue, result);
        }

        [TestMethod]
        public void CONVERT_65_to_Sixty_Five()
        {
            WordConversor wordConversor = new WordConversor();

            // input
            int number = 65;
            string experatedValue = "Sixty five".ToUpper();

            // Test
            string result = wordConversor.Convert(number).ToUpper();

            // Assert
            Assert.AreEqual(experatedValue, result);
        }

        [TestMethod]
        public void CONVERT_110_to_One_Hundred_Ten()
        {
            WordConversor wordConversor = new WordConversor();

            // input
            int number = 110;
            string experatedValue = "One hundred ten".ToUpper();

            // Test
            string result = wordConversor.Convert(number).ToUpper();

            // Assert
            Assert.AreEqual(experatedValue, result);
        }

        [TestMethod]
        public void CONVERT_102_to_One_Hundred_Two()
        {
            WordConversor wordConversor = new WordConversor();

            // input
            int number = 102;
            string experatedValue = "One hundred two".ToUpper();

            // Test
            string result = wordConversor.Convert(number).ToUpper();

            // Assert
            Assert.AreEqual(experatedValue, result);
        }

        [TestMethod]
        public void CONVERT_791_to_One_Hundred_Ten()
        {
            WordConversor wordConversor = new WordConversor();

            // input
            int number = 791;
            string experatedValue = "Seven hundred ninety one".ToUpper();

            // Test
            string result = wordConversor.Convert(number).ToUpper();

            // Assert
            Assert.AreEqual(experatedValue, result);
        }
    }
}
