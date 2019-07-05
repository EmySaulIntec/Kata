using System;
using System.Collections.Generic;
using System.Linq;
using Anagram;
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
            // Input 
            string path = @"D:\Emy\Katas\4. Anagrams\anagramData.txt";
            int experatedValue = 20683;
            
            // Test 
            IEnumerable<string> result = anagramGetter.Get(path);

            // Assert
            Assert.AreEqual(experatedValue, result.Count());

        }
    }
}
