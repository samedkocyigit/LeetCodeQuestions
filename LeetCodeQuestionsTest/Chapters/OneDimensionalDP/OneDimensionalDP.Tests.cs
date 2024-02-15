using LeetCodeQuestions.Chapters.OneDimensionalDP;
using System;
namespace LeetCodeQuestionsTests.Chapters.OneDimensionalDP;

[TestClass]
public class OneDimensionalDPTests
{
	[TestMethod]
	public void ClaimbingStairsTest()
	{
		OneDimensionalDPSolutions testObject = new OneDimensionalDPSolutions();
		int input = 4;

		int output = testObject.ClaimbingStairs(input);

		Assert.AreEqual(5,output );
	}
}

