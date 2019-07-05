using Microsoft.VisualStudio.TestTools.UnitTesting;
using StringCalculator;

namespace StringCalculatorTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ONe_PLUS_TWO()
        {
            Calculator calculator = new Calculator();

            // input
            string numbers = "//;\n1;2";
            decimal experatedValue = 3;
            
            // test
            decimal result = calculator.Calculate(numbers);

            // assert
            Assert.AreEqual(experatedValue, result);
        }

        [TestMethod]
        public void ONE_PLUS_TWO_TRHEE()
        {
            Calculator calculator = new Calculator();

            // input
            string numbers = "//|\n1|2|3";
            decimal experatedValue = 6;

            // test
            decimal result = calculator.Calculate(numbers);

            // assert
            Assert.AreEqual(experatedValue, result);
        }

        [TestMethod]
        public void TWO_PLUS_TRHEE()
        {
            Calculator calculator = new Calculator();

            // input
            string numbers = "//sep\n2sep3";
            decimal experatedValue = 5;

            // test
            decimal result = calculator.Calculate(numbers);

            // assert
            Assert.AreEqual(experatedValue, result);
        }

        [TestMethod]
        public void INVALID_1_2_3()
        {
            Calculator calculator = new Calculator();

            // input
            string numbers = "//|\n1|2,3";
            decimal experatedValue = 5;

            // test
            decimal result = calculator.Calculate(numbers);

            // assert
            Assert.AreEqual(experatedValue, result);
        }
    }
}
