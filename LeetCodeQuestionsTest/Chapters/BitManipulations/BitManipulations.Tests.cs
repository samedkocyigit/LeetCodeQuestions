using LeetCodeQuestions.Chapters.BitManipulations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeQuestionsTests.Chapters.BitManupulations;

[TestClass]
public class BitManupilationsTests
{
    [TestMethod]
    public void AddBinaryTest()
    {
        BitManipulationsSolutions testObject = new BitManipulationsSolutions();
        int a = 11;
        int b = 1;

        int result = testObject.AddBinary(a, b);
        Assert.AreEqual(100, result);

    }

    [TestMethod]
    public void ReverseBitsTest() 
    {
        BitManipulationsSolutions testObject = new BitManipulationsSolutions();
        string input = "00000010100101000001111010011100";
        double output = testObject.ReverseBits(input);

        Assert.AreEqual(964176192, output);
    }
}
