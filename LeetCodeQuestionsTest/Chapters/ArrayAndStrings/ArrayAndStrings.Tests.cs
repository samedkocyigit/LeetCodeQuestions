using LeetCodeQuestions.Chapters.ArrayAndStrings;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections;

namespace LeetCodeQuestionTest.Chapters.ArrayAndStringsTest
{
    [TestClass]
    public class ArrayAndStringsTests
    {
        [TestMethod]
        public void MergeSortedArrTest()
        {
            ArrayAndStringsSolutions testObject = new ArrayAndStringsSolutions();
            int[] arrOne = { 1, 2, 3, 0, 0, 0 };
            int m = 3;
            int[] arrTwo = { 2, 3, 5 };
            int n = 3;

            int[] outputArr = testObject.MergeSortedArr(arrOne, m, arrTwo, n);

            Assert.AreEqual(1, outputArr[0]);
            Assert.AreEqual(2, outputArr[1]);
            Assert.AreEqual(2, outputArr[2]);
            Assert.AreEqual(3, outputArr[3]);
            Assert.AreEqual(3, outputArr[4]);
            Assert.AreEqual(5, outputArr[5]);
        }

        [TestMethod]
        public void RemoveElementsTest()
        {
            ArrayAndStringsSolutions testObject = new ArrayAndStringsSolutions();
            int[] arrOne = { 1, 2, 3, 2, 0, 0 };
            int removeValue = 0;

            int[] outputArr = testObject.RemoveElements(arrOne, removeValue);

            Assert.AreEqual(4, outputArr.Length);
        }

        [TestMethod]

        public void UniqueArrayTest()
        {
            ArrayAndStringsSolutions testObject = new ArrayAndStringsSolutions();
            int[] inputArr = { 0, 0, 1, 1, 2, 3, 3, 4, 5 };

            ArrayList outputArr = testObject.UniqueArray(inputArr);

            Assert.AreEqual(6, outputArr.Count);
            Assert.AreEqual(0, outputArr[0]);
            Assert.AreEqual(1, outputArr[1]);
            Assert.AreEqual(2, outputArr[2]);
            Assert.AreEqual(3, outputArr[3]);
            Assert.AreEqual(4, outputArr[4]);
            Assert.AreEqual(5, outputArr[5]);
        }

        [TestMethod]
        public void DublicateArrayTest()
        {
            ArrayAndStringsSolutions testObject = new ArrayAndStringsSolutions();
            int[] inputArr = { 0, 0, 1, 1, 1, 3, 3, 4, 5 };

            ArrayList outputArr = testObject.DublicateArray(inputArr);

            Assert.AreEqual(8, outputArr.Count);
            Assert.AreEqual(0, outputArr[0]);
            Assert.AreEqual(0, outputArr[1]);
            Assert.AreEqual(1, outputArr[2]);
            Assert.AreEqual(1, outputArr[3]);
            Assert.AreEqual(3, outputArr[4]);
            Assert.AreEqual(3, outputArr[5]);
            Assert.AreEqual(4, outputArr[6]);
            Assert.AreEqual(5, outputArr[7]);
        }

        [TestMethod]
        public void MajorityElementTest()
        {
            ArrayAndStringsSolutions testObject = new ArrayAndStringsSolutions();
            int[] inputArr = { 0, 1, 2, 2, 3, 2, 3, 0, 0, 1, 1, 1 };
            int majorElement = testObject.MajorElement(inputArr);

            Assert.AreEqual(1, majorElement);
        }

        [TestMethod]
        public void RotateArrayTest()
        {
            ArrayAndStringsSolutions testObject = new ArrayAndStringsSolutions();
            int[] array = { 0, 1, 2, 3, 4, 5 };
            int k = 3;
            int[] outputArr = testObject.RotateArray(array, k);

            Assert.AreEqual(3, outputArr[0]);
            Assert.AreEqual(4, outputArr[1]);
            Assert.AreEqual(5, outputArr[2]);
            Assert.AreEqual(0, outputArr[3]);
            Assert.AreEqual(1, outputArr[4]);
            Assert.AreEqual(2, outputArr[5]);
        }

        [TestMethod]

        public void BestProfitTest()
        {
            ArrayAndStringsSolutions testObject = new ArrayAndStringsSolutions();
            int[] array = { 7, 2, 1, 5, 4, 3, 8 };
            int output = testObject.BestProfit(array);

            Assert.AreEqual(7, output);
        }

        [TestMethod]

        public void BestProfitTestTwo()
        {
            ArrayAndStringsSolutions testObject = new ArrayAndStringsSolutions();

            int[] array = { 2, 6, 8, 9, 10, 9 };
            int output = testObject.BestProfitTwo(array);

            Assert.AreEqual(8, output);
        }

        [TestMethod]
        public void JumpGameTest()
        {
            ArrayAndStringsSolutions testObject = new ArrayAndStringsSolutions();

            int[] inputArr = { 2, 4, 1, 0, 2, 3, 2, 2, 1 };
            bool flag = testObject.JumpGame(inputArr);

            Assert.AreEqual(true, flag);

        }

        [TestMethod]

        public void JumpGameTest2()
        {
            ArrayAndStringsSolutions testObject = new ArrayAndStringsSolutions();
            int[] inputArr = { 2, 3, 1, 0, 2, 3, 2, 2, 1 };

            int output = testObject.JumpGame2(inputArr);

            Assert.AreEqual(4, output);
        }

        [TestMethod]
        public void ProductOfArrayExceptSelf()
        {
            ArrayAndStringsSolutions testObject = new ArrayAndStringsSolutions();

            int[] inputArr = { -1, 1, 0, -3, 3 };
            int[] outputArr = testObject.arrMultiplication(inputArr);

            Assert.AreEqual(0, outputArr[0]);
            Assert.AreEqual(0, outputArr[1]);
            Assert.AreEqual(9, outputArr[2]);
            Assert.AreEqual(0, outputArr[3]);
            Assert.AreEqual(0, outputArr[4]);

        }

        [TestMethod]

        public void GasStationTest()
        {
            ArrayAndStringsSolutions testObject = new ArrayAndStringsSolutions();

            int[] station = { 1, 2, 3, 4, 5 };
            int[] cost = { 3, 4, 5, 1, 2 };

            int output = testObject.gasStation(station,cost);

            Assert.AreEqual(3,output);
        }

        [TestMethod]

        public void RainTrapTest()
        {
            ArrayAndStringsSolutions testObject = new ArrayAndStringsSolutions();

            int[] trap = { 4, 2, 0, 3, 2,5};
            int output = testObject.RainTrap(trap);

            Assert.AreEqual(9,output);
        }

        [TestMethod]
        public void RomanNumberTest()
        {
            ArrayAndStringsSolutions testObject = new ArrayAndStringsSolutions();
            string? input = "LVIII";
            int output = testObject.RomanNumber(input);

            Assert.AreEqual(58,output);
        }

        [TestMethod]
        public void RomanNumberTest2()
        {
            ArrayAndStringsSolutions testObject = new ArrayAndStringsSolutions();
            string? input = "MCMXCIV";
            int output = testObject.RomanNumber(input);

            Assert.AreEqual(1994, output);
        }

        



































    }
}