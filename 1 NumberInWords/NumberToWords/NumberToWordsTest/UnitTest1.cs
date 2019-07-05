using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NumberToWords;

namespace NumberToWordsTest
{
    [TestClass]
    public class UnitTest1
    {
        //[TestMethod]
        public void TestMethod1()
        {

            ConvertToWords convertToWords = new ConvertToWords();

            // Input
            int number = 745;
            string experatedValue = "seven hundred and fourty five";

            // Test
            string result = convertToWords.Convert(number);

            // Assert
            Assert.AreEqual(experatedValue, result);
        }

        [TestMethod]
        public void CONVERT_1_ONE()
        {

            ConvertToWords convertToWords = new ConvertToWords();

            // Input
            int number = 2110;
            string experatedValue = "Two thousand one hundred ten".ToUpper();

            // Test
            string result = convertToWords.Convert(number).ToUpper();

            // Assert
            Assert.AreEqual(experatedValue, result);
        }
    }
}
