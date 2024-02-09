using System;
using LeetCodeQuestions.Chapters.Maths;
namespace LeetCodeQuestionsTests.Chapters.Math;

[TestClass]
public class MathTests
{
	[TestMethod]
	public void PolindromeNumberTest()
	{
		MathsSolutions testObject = new MathsSolutions();
		int num = 1224;
		int num1 = 1234554321;
		bool output = testObject.PolindromeNumber(num);
		bool output1 = testObject.PolindromeNumber(num1);

		Assert.AreEqual(false, output);
        Assert.AreEqual(true, output1);
    }

	[TestMethod]
	public void AddOneTest()
	{
		MathsSolutions testObject = new MathsSolutions();
		int[] arr = new int[] { 9, 9, 9, 9 };

		int[] output = testObject.AddOne(arr);

		Assert.AreEqual(0, output[4]);

	}
}

