using System;
using System.Collections.Generic;
using System.IO.IsolatedStorage;
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

        public int[] TwoSum(int[] arr,int target)
        {
            int length = arr.Length;
            int[] result = new int[2];
            int temp = 0;

            for (int i = 0; i < length; i++)
            {
                for (int j = length-1; j > i; j--)
                {
                    temp = arr[i] + arr[j];
                    if (temp == 9)
                    {
                        result[0] = arr[i];
                        result[1] = arr[j];
                        return result;
                    }
                    temp = 0;
                }
            }
            return result;
        }
    }
}
