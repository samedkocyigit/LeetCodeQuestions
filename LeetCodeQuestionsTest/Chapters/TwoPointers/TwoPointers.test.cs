using LeetCodeQuestions.Chapters.TwoPointers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeQuestionsTests.Chapters.TwoPointers
{
    [TestClass]
    public class TwoPointers
    {
        [TestMethod]

        public void validPalindromeTest()
        {
            TwoPointersSolutions testObject = new TwoPointersSolutions();
            string input = "A man, a plan, a canal: Panama";
            bool output = testObject.ValidPalindrome(input);

            Assert.AreEqual(true,output);
        }
        [TestMethod]
        public void isSubsequenceTest() 
        {
            TwoPointersSolutions testObject = new TwoPointersSolutions();
            string inputOne = "abc";
            string inputTwo = "ahbgdc";

            bool output = testObject.isSubsequence(inputOne,inputTwo);
            bool outputTwo=testObject.isSebsequenceSecond(inputOne,inputTwo);
            
            Assert.AreEqual(true,output);
            Assert.AreEqual(true,outputTwo);   
        }

    }
}
