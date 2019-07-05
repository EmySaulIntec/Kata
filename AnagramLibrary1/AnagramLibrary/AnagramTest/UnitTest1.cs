using System;
using System.Collections.Generic;
using System.Linq;
using AnagramLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AnagramTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            AnagramGetter anagramGetter = new AnagramGetter();

            // input
            string path = @"D:\Emy\Katas\4. Anagrams\anagramData.txt";
            int experatedValue = 20683;
            // test
            IEnumerable<string> anagrams = anagramGetter.Get(path);

            // assert
            Assert.AreEqual(experatedValue, anagrams.Count());
        }
    }
}
