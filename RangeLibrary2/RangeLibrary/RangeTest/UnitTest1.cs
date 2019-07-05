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
        public void INTEGER_RANGE_2_6_CONTAIN_2_4()
        {
            RangeConverter rangeConverter = new RangeConverter();

            // input
            string set = "[2,6)";
            var subSet = new List<int>() { 2, 4 };
            bool resultExperated = true;

            // Test
            bool result = rangeConverter.IntegerContain(set, subSet);

            // Assert
            Assert.AreEqual(resultExperated, result);
        }


        [TestMethod]
        public void INTEGER_RANGE_2_6_NOT_CONTAIN_Minus_1_1_6_10()
        {
            RangeConverter rangeConverter = new RangeConverter();

            // input
            string set = "[2,6)";
            var subSet = new List<int>() { -1, 1, 6, 10 };
            bool resultExperated = false;

            // Test
            bool result = rangeConverter.IntegerContain(set, subSet);

            // Assert
            Assert.AreEqual(resultExperated, result);
        }


        [TestMethod]
        public void GET_ALL_POINTS_FROM_2_TO_6()
        {
            RangeConverter rangeConverter = new RangeConverter();

            // input
            string set = "[2,6)";
            var subSet = new List<int>() { 2, 3, 4, 5 };
            int countListExperated = 4;
            bool experatedElementsInResult = true;

            // Test
            IEnumerable<int> result = rangeConverter.GetAllPoints(set);

            // Assert

            var forAllElementsExists = result.All(e => subSet.Contains(e));


            Assert.AreEqual(countListExperated, result.Count());

            Assert.AreEqual(forAllElementsExists, experatedElementsInResult);
        }


        [TestMethod]
        public void CONTAIN_RANGE_2_To_5_NOT_CONTAIN_7_TO_10()
        {
            RangeConverter rangeConverter = new RangeConverter();

            // input
            string set = "[2,5)";
            string otherSet = "[7,10)";
            bool resultExperated = false;

            // Test
            bool result = rangeConverter.RangeContain(set, otherSet);

            // Assert
            Assert.AreEqual(resultExperated, result);
        }

        [TestMethod]
        public void CONTAIN_RANGE_2_To_5_NOT_CONTAIN_3_TO_10()
        {
            RangeConverter rangeConverter = new RangeConverter();

            // input
            string set = "[2,5)";
            string otherSet = "[3,10)";
            bool resultExperated = false;

            // Test
            bool result = rangeConverter.RangeContain(set, otherSet);

            // Assert
            Assert.AreEqual(resultExperated, result);
        }


        [TestMethod]
        public void CONTAIN_RANGE_3_To_5_NOT_CONTAIN_2_TO_10()
        {
            RangeConverter rangeConverter = new RangeConverter();

            // input
            string set = "[3,5)";
            string otherSet = "[2,10)";
            bool resultExperated = false;

            // Test
            bool result = rangeConverter.RangeContain(set, otherSet);

            // Assert
            Assert.AreEqual(resultExperated, result);
        }


        [TestMethod]
        public void CONTAIN_RANGE_2_To_10_CONTAIN_3_TO_5()
        {
            RangeConverter rangeConverter = new RangeConverter();

            // input
            string set = "[2,10)";
            string otherSet = "[3,5]";
            bool resultExperated = true;

            // Test
            bool result = rangeConverter.RangeContain(set, otherSet);

            // Assert
            Assert.AreEqual(resultExperated, result);
        }

        [TestMethod]
        public void CONTAIN_RANGE_3_To_5_CONTAIN_3_TO_5()
        {
            RangeConverter rangeConverter = new RangeConverter();

            // input
            string set = "[3,5]";
            string otherSet = "[3,5)";
            bool resultExperated = true;

            // Test
            bool result = rangeConverter.RangeContain(set, otherSet);

            // Assert
            Assert.AreEqual(resultExperated, result);
        }


        [TestMethod]
        public void END_POINTS_2_6_END_2_5()
        {
            RangeConverter rangeConverter = new RangeConverter();

            // input
            string set = "[2,6)";
            var endPoints = new int[2] { 2, 5 };

            bool resultExperated = true;

            // Test
            bool result = rangeConverter.EndPoints(set, endPoints);

            // Assert
            Assert.AreEqual(resultExperated, result);
        }

    }
}
