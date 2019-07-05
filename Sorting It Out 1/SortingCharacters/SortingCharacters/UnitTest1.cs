using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SortingCharactersB;

namespace SortingCharacters
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void LETTERS_WITHOUT_SPACE()
        {
            Sorter sorter = new Sorter();

            // input 
            string input = "dbacdedecd";
            string expectedValue = "abccddddee";

            string orderedText = sorter.Order(input);

            Assert.AreEqual(expectedValue, orderedText);
        }

        [TestMethod]
        public void LETTERS_WITH_SPACE()
        {
            Sorter sorter = new Sorter();

            // input 
            string input = "dba cde dec d, ";
            string expectedValue = "abccddddee";

            string orderedText = sorter.Order(input);

            Assert.AreEqual(expectedValue, orderedText);
        }
    }
}
