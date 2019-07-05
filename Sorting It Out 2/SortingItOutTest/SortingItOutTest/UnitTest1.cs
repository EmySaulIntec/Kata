using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SortingItOut;

namespace SortingItOutTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void dada_to_aadd()
        {
            Sorter sorter = new Sorter();

            // input
            string input = "dada";
            string experatedValue = "aadd";

            // Test
            string result = sorter.Sort(input);

            // Assert
            Assert.AreEqual(experatedValue, result);

        }

        [TestMethod]
        public void dada_to_aadd_with_space()
        {
            Sorter sorter = new Sorter();

            // input
            string input = "da da ";
            string experatedValue = "aadd";

            // Test
            string result = sorter.Sort(input);

            // Assert
            Assert.AreEqual(experatedValue, result);

        }

        [TestMethod]
        public void CompletePhrase()
        {
            Sorter sorter = new Sorter();

            // input
            string input = "When not studying nuclear physics, Bambi likes to play beach volleyball.";
            string experatedValue = "aaaaabbbbcccdeeeeeghhhiiiiklllllllmnnnnooopprsssstttuuvwyyyy";

            // Test
            string result = sorter.Sort(input);

            // Assert
            Assert.AreEqual(experatedValue, result);

        }
    }
}
