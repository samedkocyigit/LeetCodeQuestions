using LeetCodeQuestions.Chapters.BitManipulations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeQuestionsTests.Chapters.BitManupulations
{
    [TestClass]
    public class BitManupilations
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
    }
}
