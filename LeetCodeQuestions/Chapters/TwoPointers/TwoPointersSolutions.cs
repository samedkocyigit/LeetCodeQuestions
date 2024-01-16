using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LeetCodeQuestions.Chapters.TwoPointers
{
    public class TwoPointersSolutions
    {
        public bool ValidPalindrome(string input)
        {
            input = input.ToLower();
            input = Regex.Replace(input,"[^0-9A-Za-z _-]", "");
            input = input.Replace(" ", "");
            int length = input.Length;

            if (input == null) { return true; }
            else
            {
                for(int i = 0; i < input.Length/2; i++,length--)
                {
                    if(input[i] != input[length - 1]) { return false; }
                }
            }
            return true;
        } 

        public bool isSubsequence(string inputOne,string inputTwo) 
        {
            int counter = 0;
            for (int i = 0; i < inputOne.Length; i++)
            {
                for (int j = 0; j < inputTwo.Length; j++)
                {
                    if (inputOne[i] == inputTwo[j]) 
                    {   
                        counter++;
                        break;
                    }
                }
            }
            if (counter == inputOne.Length) { return true; }
            else { return false; }
         
        }
        public bool isSebsequenceSecond(string inputOne,string inputTwo)
        {
            
            for (int i = 0; i < inputOne.Length; i++)
            {
                if (inputTwo.Contains(inputOne[i])){ }
                else { return false; }
            }
            return true;
        }
    }
}
