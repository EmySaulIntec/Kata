using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RangeLibrary;

namespace RangeTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void INTEGER_RANGE_CONTAIN_FROM_2_TO_6_ELEMENTS_2_4()
        {

            RangeController rangeController = new RangeController();
            // inputs

            // test
            const string Set = "[2,6)";
            var subset = new List<int>() { 2, 4 };
            bool experatedValue = true;


            bool result = rangeController.IntegerRangeContain(Set, subset);

            // assert
            Assert.AreEqual(experatedValue, result);

        }

        [TestMethod]
        public void INTEGER_RANGE_2_to_6_NOT_CONTAIN_Minus_1_1_6_10_()
        {

            RangeController rangeController = new RangeController();
            // inputs

            // test
            const string Set = "[2,6)";
            var subset = new List<int>() { -1, 1, 6, 10 };
            bool experatedValue = false;


            bool result = rangeController.IntegerRangeContain(Set, subset);

            // assert
            Assert.AreEqual(experatedValue, result);

        }

        // Este se quedara hasta aqui, debido a que son 30 min. por video.

        [TestMethod]
        public void GET_ALL_POINTS__2_to_6()
        {
            // inputs
            RangeController rangeController = new RangeController();

            const string Set = "[2,6)";
            List<int> experatedValue = new List<int>() { 2, 3, 4, 5 };
            bool experatedHaveAllElements = true;

            // test
            List<int> result = rangeController.GetAllPointsFromSet(Set).ToList();


           var haveAllElements = result.All(e => experatedValue.Contains(e));

            // assert
            Assert.AreEqual(experatedValue.Count, result.Count);
            Assert.AreEqual(experatedHaveAllElements, haveAllElements);

        }
    }
}
