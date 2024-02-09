using System;

namespace LeetCodeQuestions.Chapters.Maths;

public class MathsSolutions
{
    public bool PolindromeNumber(int num)
    {
        bool output = true;
        string str = num.ToString();
        int length = str.Length;

        if (length <= 1) return false;

        for (int i = 0; i < str.Length / 2; i++, length--)
        {
            if (str[i] != str[length - 1]) { output = false; }
        }

        return output;
    }

    public int[] AddOne(int[] arr)
    {
        int length = arr.Length;

        for (int i = length-1; i >=0; i--)
        {
            if (arr[i] < 9)
            {
                arr[i]++;
                return arr;
            }
            arr[i] = 0;
        }
        int[] newArr = new int[length + 1];
        newArr[0] = 1;
        return newArr;
    }
}

