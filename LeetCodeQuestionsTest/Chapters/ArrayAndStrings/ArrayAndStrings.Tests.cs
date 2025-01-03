﻿using LeetCodeQuestions.Chapters.ArrayAndStrings;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections;

namespace LeetCodeQuestionTest.Chapters.ArrayAndStringsTest;

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
    public void RomanToIntegerTest()
    {
        ArrayAndStringsSolutions testObject = new ArrayAndStringsSolutions();
        string? input = "LVIII";
        int output = testObject.RomanToInteger(input);

        Assert.AreEqual(58,output);
    }

    [TestMethod]
    public void RomanToIntegerTest2()
    {
        ArrayAndStringsSolutions testObject = new ArrayAndStringsSolutions();
        string? input = "MCMXCIV";
        int output = testObject.RomanToInteger(input);

        Assert.AreEqual(1994, output);
    }

    [TestMethod]

    public void IntegerToRomanTest()
    {
        ArrayAndStringsSolutions testobject = new ArrayAndStringsSolutions();

        int number = 1994;
        string output = testobject.IntegerToRoman(number);

        Assert.AreEqual("MCMXCIV", output);
    }

    [TestMethod]
    public void LengthLastWordTest()
    {
        ArrayAndStringsSolutions testObject = new ArrayAndStringsSolutions();

        string sentence = "Messi sadsa sadsad sdasdsad messi";
        int lenght = testObject.LengthLastWord(sentence);

        Assert.AreEqual(5,lenght);
    }

    [TestMethod]
    public void LongestCommonPrefixTest()
    {
        ArrayAndStringsSolutions testObject = new ArrayAndStringsSolutions();

        string[] arr = { "flllower", "flllight", "fllow" };
        string common = testObject.LongestCommonPrefix(arr);

        Assert.AreEqual("fll", common);
    }

    [TestMethod]
    public void ReverseWordsInStringTest()
    {
        ArrayAndStringsSolutions testObject = new ArrayAndStringsSolutions();
        string sentence = "messi  is the Goat";
        string output = testObject.ReverseWordsInString(sentence);

        Assert.AreEqual("taoG eht si issem", output);
    }

    [TestMethod]

    public void ZigzagConversionTest()
    {
        ArrayAndStringsSolutions testObject = new ArrayAndStringsSolutions();
        string input = "MESSIISTHEGOAT";
        int numRows = 4;
        string output = testObject.ZigzagConversion(input,numRows);

        Assert.AreEqual("MSAEITOTSIHGSE", output);
    }

    [TestMethod]

    public void TextJustificationTest()
    {
        ArrayAndStringsSolutions testObject = new ArrayAndStringsSolutions();
        string[] input = { "Hello", "world", "this", "is", "the", "text", "justification", "test", "scenario" };
        int maxWidth = 16;

        var result = testObject.TextJustification(input, maxWidth);

        Assert.AreEqual("Hello world this", result[0]);
        Assert.AreEqual("is    the   text", result[1]);
        Assert.AreEqual("justification   ", result[2]);
        Assert.AreEqual("test scenario   ", result[3]);
    }
    [TestMethod]
    public void RobberTest()
    {
        ArrayAndStringsSolutions testObject = new ArrayAndStringsSolutions();
        int[] input = { 1,2,3,4,6,5,5,5,5};
        var result = testObject.Robber(input);

        Assert.AreEqual(20, result);
    }
    [TestMethod]
    public void GymCounterTest() 
    {
        ArrayAndStringsSolutions testObject = new ArrayAndStringsSolutions();
        string[] input = { "Salı", "Perşembe", "Pazar", "Pazartesi", "Cumartesi", "Salı", "Pazartesi", "Pazartesi", "Çarşamba", "Salı" };
        var result = testObject.GymCounter(input);

        Assert.AreEqual(6, result);
    }




































}