using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StringCalculator;

namespace StringCalculatorTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TWO_PLUS_TRHEE_WITH_SPLIT()
        {
            Calculator calculator = new Calculator();

            // input
            string numbers = "//;\n2;3";
            decimal experatedValue = 5;

            // Test
            decimal result = calculator.Convert(numbers);

            // End
            Assert.AreEqual(experatedValue, result);
        }

        [TestMethod]
        public void ONE_PLUS_TWO_PLUS_TRHEE_WITHOUT_SPLIT()
        {
            Calculator calculator = new Calculator();

            // input
            string numbers = "1\n2,3";
            decimal experatedValue = 6;

            // Test
            decimal result = calculator.Convert(numbers);

            // End
            Assert.AreEqual(experatedValue, result);
        }

        [TestMethod]
        public void EMPTY_RETURN_ZERO()
        {
            Calculator calculator = new Calculator();

            // input
            string numbers = "";
            decimal experatedValue = 0;

            // Test
            decimal result = calculator.Convert(numbers);

            // End
            Assert.AreEqual(experatedValue, result);
        }

        [TestMethod]
        public void MINUS_TWO_PLUS_TWO_RETURN_ERROR()
        {
            Calculator calculator = new Calculator();

            // input
            string numbers = "-1,2";
            string experatedValue = "Negative not allowed : -1";

            // Test
            decimal result = calculator.Convert(numbers);

            // End
            Assert.AreEqual(calculator.ErrorMessage, experatedValue);
        }
    }
}
