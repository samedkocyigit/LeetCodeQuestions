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

    public int FactorialTrailingZeroes(int num)
    {
        int output=0;
        int fact = FactorialFunc(num);
        int x = 10;
        bool flag = true;
        while (flag!=false)
        {
            if (fact % x == 0)
            {
                output++;
                x *= 10;
            }
            else
                flag = false;
        }

        return output;
    }
    public int FactorialFunc(int a)
    {
        if (a == 0)
            return 1;

        return a * FactorialFunc(a - 1);
    }

    public int SquareRoot(int num) 
    {
        int first=0, last=num;
        while (first <= last)
        {
            long mid=(first+last)/2,temp=mid*mid;

            if (temp == num) return (int)mid;

            else if(temp>num) last = (int)(mid - 1);

            else first =(int)(mid + 1);
        }
        return last;
    }
}

