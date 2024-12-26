using System.Security.Cryptography.X509Certificates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.ComponentModel.DataAnnotations;

namespace LeetCodeQuestions.Chapters.ArrayAndStrings;

public class ArrayAndStringsSolutions
{
    public int[] MergeSortedArr(int[] nums1, int m, int[] nums2, int n)
    {
        for (int j = 0, i = m; j < n; j++, i++)
        {
            nums1[i] = nums2[j];
        }
        Array.Sort(nums1);

        return nums1;
    }
    public int[] RemoveElements(int[] arr, int val)
    {
        int count = 0;
        for (int j = 0; j < arr.Length; j++)
        {
            if (arr[j] == val)
            {
                count++;
            }
        }

        int[] tempArr = new int[arr.Length - count];

        for (int i = 0, k = 0; i < arr.Length; i++)
        {
            if (arr[i] != 0)
            {
                tempArr[k] = arr[i];
                k++;
            }
        }

        return tempArr;
    }
    public ArrayList UniqueArray(int[] arr)
    {
        ArrayList tempArr = new ArrayList();

        for (int i = 0; i < arr.Length; i++)
        {
            if (!tempArr.Contains(arr[i]))
            {
                tempArr.Add(arr[i]);
            }
        }
        return tempArr;
    }

    public ArrayList DublicateArray(int[] arr)
    {
        int counter = 1;               // 0,0,1,1,1,2,2,3, ----> 0,0,1,1,2,2,3
        ArrayList tempArr = new ArrayList();

        for (int i = 0; i < arr.Length; i++)
        {
            if (!tempArr.Contains(arr[i]))
            {
                tempArr.Add(arr[i]);
                counter++;
            }
            else
            {
                if (counter == 2)
                {
                    tempArr.Add(arr[i]);
                    counter = 1;
                }
            }
        }
        return tempArr;
    }
    public int MajorElement(int[] arr)
    {
        int counter = 0;
        Dictionary<int, int> h1 = new Dictionary<int, int>();
        for (int i = 0; i < arr.Length; i++)
        {
            for (int j = 0; j < arr.Length; j++)
            {
                if (arr[i] == arr[j] && !h1.ContainsKey(arr[i]))
                {
                    counter++;
                }
            }
            if (!h1.ContainsKey(arr[i]))
            { h1.Add(arr[i], counter); }
            counter = 0;
        }

        int output = h1.MaxBy(h1 => h1.Value).Key;
        return output;
    }

    public int[] RotateArray(int[] arr, int k)
    {
        int lastElement;
        for (int i = 0; i < k; i++)
        {
            lastElement = arr[arr.Length - 1];
            for (int j = arr.Length - 1; j > 0; j--)
            {
                arr[j] = arr[j - 1];
            }
            arr[0] = lastElement;
        }

        return arr;
    }

    public int BestProfit(int[] arr)
    {
        ArrayList tempArr = new ArrayList();
        int profits;
        //array = { 7, 1, 5, 3, 6, 4 }   {1,7,2,4,5,3}

        for (int i = 0; i < arr.Length; i++)
        {
            for (int j = arr.Length - 1; j > 0; j--)
            {
                if (j > i)
                    tempArr.Add(arr[j] - arr[i]);
            }
        }
        tempArr.Sort();
        tempArr.Reverse();
        profits = (int)tempArr[0];
        if (profits < 0)
            profits = 0;

        return profits;
    }

    public int BestProfitTwo(int[] arr)
    {
        int profit = 0;
        int buyDay = 0, sellDay = 0;

        if (arr.Length == 1)
            return 0;

        for (int i = 1; i < arr.Length - 1; i++)
        {
            if (arr[i] > arr[i - 1])
                buyDay++;
            else
            {
                profit += arr[buyDay] - arr[sellDay];
                buyDay = sellDay = i;
            }
        }
        profit += arr[buyDay] - arr[sellDay];

        return profit;
    }
    public bool JumpGame(int[] arr)
    {
        int index;
        int length = arr.Length;

        for (int j = 1; j < length;)
        {
            index = arr[j];
            if (index == 0 || (j + index) > (length - 1)) { return false; }

            j = j + index;

            if (j == length - 1) { return true; }
        }

        return false;
    }

    public int JumpGame2(int[] arr)
    {
        int index;
        int length = arr.Length;
        int counter = 1;

        for (int j = 1; j < length;)
        {
            index = arr[j];

            if (index == 0 || (j + index) > (length - 1)) { return 0; }

            j = j + index;
            counter++;
            if (j == length - 1) { return counter; }
        }
        return 0;
    }

    public int[] arrMultiplication(int[] arr)
    {
        int[] outputArr = new int[arr.Length];
        int temp = 1;
        for (int i = 0; i < arr.Length; i++)
        {
            for (int j = 0; j < arr.Length; j++)
            {
                if (i == j) continue;
                temp *= arr[j];
            }
            outputArr[i] = temp;
            temp = 1;
        }

        return outputArr;
    }

    public int gasStation(int[] arrStation, int[] arrCost)
    {
        int gas = 0;
        int length = arrStation.Length;
        int i = 0, j = -1, index = 0;
        bool flag = false;
        do
        {
            if (arrStation.Sum() < arrCost.Sum()) { return -1; }
            if (arrStation[i] >= arrCost[i] || gas >= arrCost[i])
            {
                if (gas == 0) { gas += arrStation[i]; }
                else { gas += arrStation[i] - arrCost[j]; }

                index++;
                if (index == arrCost.Length) { flag = true; }
            }

            j++; if (j >= length) { j = 0; }
            i++; if (i >= length) { i = 0; }
        } while (flag == false);
        return i;
    }

    public int RainTrap(int[] arr)
    {
        int length = arr.Length;
        int sum = 0;
        int leftPose = 1;
        int rightPose = length - 2;
        int leftMax = arr[0];
        int rightMax = arr[length - 1];

        while (leftPose <= rightPose)
        {
            if (arr[leftPose] >= leftMax)
            {
                leftMax = arr[leftPose];
                leftPose++;
            }
            else if (arr[rightPose] >= rightMax)
            {
                rightMax = arr[rightPose];
                rightPose--;
            }
            else if (leftMax <= rightMax && arr[leftPose] < leftMax)
            {
                sum += leftMax - arr[leftPose];
                leftPose++;
            }
            else
            {
                sum += rightMax - arr[rightPose];
                rightPose--;
            }
        }
        return sum;
    }

    public int RomanToInteger(string input)
    {
        int temp = 0;
        int result = 0;
        Dictionary<char, int> romanEmpire = new Dictionary<char, int>()
        {
            {'M',1000 },
            {'D',500 },
            {'C',100 },
            {'L',50 },
            {'X',10 },
            {'V',5 },
            {'I',1 }
        };

        for (int i = input.Length - 1; i >= 0; i--)
        {
            if (romanEmpire[input[i]] >= temp)
            {
                result += romanEmpire[input[i]];
            }
            else
            {
                result -= romanEmpire[input[i]];
            }
            temp = romanEmpire[input[i]];
        }

        return result;
    }

    public string IntegerToRoman(int num)
    {
        if (num >= 1000) return "M" + IntegerToRoman(num - 1000);

        if (num >= 500) return num >= 900 ? ("CM" + IntegerToRoman(num - 900)) : ("D" + IntegerToRoman(num - 500));

        if (num >= 100) return num >= 400 ? ("CD" + IntegerToRoman(num - 400)) : ("C" + IntegerToRoman(num - 100));

        if (num >= 50) return num >= 90 ? ("XC" + IntegerToRoman(num - 90)) : ("L" + IntegerToRoman(num - 50));

        if (num >= 10) return num >= 40 ? ("XL" + IntegerToRoman(num - 40)) : ("X" + IntegerToRoman(num - 10));

        if (num >= 5) return num == 9 ? "IX" : "V" + IntegerToRoman(num - 5);

        if (num > 0) return num == 4 ? "IV" : "I" + IntegerToRoman(num - 1);

        return "";
    }

    public int LengthLastWord(string input)
    {
        int length = input.Length - 1;
        int counter = 0;

        for (int i = length; i >= 0; i--)
        {
            if (input[i] != ' ')
                counter++;
            else
                break;
        }
        return counter;
    }

    public string LongestCommonPrefix(string[] strs)
    {
        if (strs == null || strs.Length == 0)  // If the input array is null or empty, return an empty string
            return "";

        string prefix = strs[0];  // Initialize prefix with the first string in the array

        for (int i = 1; i < strs.Length; i++)
        {
            // Keep reducing the prefix until it is a prefix of the current string
            while (!strs[i].StartsWith(prefix))
            {
                prefix = prefix.Substring(0, prefix.Length - 1);

                if (string.IsNullOrEmpty(prefix))
                    return "";  // If the prefix becomes empty, return an empty string
            }
        }

        return prefix;
    }

    public string ReverseWordsInString(string input)
    {
        for (int i = 0; i < input.Length - 1; i++)
        {
            if (input[i] == ' ' && input[i + 1] == ' ')
            {
                input = input.Remove(i + 1, 1);
            }
        }
        char[] template = new char[input.Length];
        for (int i = input.Length - 1, j = 0; i >= 0; i--, j++)
        {
            template[j] = input[i];
        }
        string output = new string(template);
        return output;
    }

    public string ZigzagConversion(string input, int num)
    {
        if (num == 1)
            return input;

        var result = new StringBuilder();
        var perIter = num * 2 - 2;
        for (int row = 0; row < num; row++)
        {
            int i = 0;
            while ((i + row) < input.Length)
            {
                result.Append(input[i + row]);
                if (row != 0 && row != num - 1)
                {
                    if ((i + perIter - row) < input.Length)
                    {
                        result.Append(input[i + perIter - row]);
                    }
                }

                i += perIter;
            }
        }
        return result.ToString();
    }

    public IList<string> TextJustification(string[] words, int maxWidth)
    {
        //{ "Hello", "world", "this", "is", "the", "text", "justification", "test", "scenario" };
        var result = new List<string>();
        var current = new List<string>();
        int num_of_letters = 0;

        foreach (var word in words)
        {
            if (word.Length + current.Count + num_of_letters > maxWidth)
            {
                for (int i = 0; i < maxWidth - num_of_letters; i++)
                {
                    current[i % (current.Count - 1 > 0 ? current.Count - 1 : 1)] += " ";
                }
                result.Add(string.Join("", current));
                current.Clear();
                num_of_letters = 0;
            }
            current.Add(word);
            num_of_letters += word.Length;
        }

        string lastLine = string.Join(" ", current);
        while (lastLine.Length < maxWidth) lastLine += " ";
        result.Add(lastLine);

        return result;
    }
    public int Robber(int[] input)
    {
        //2,23,20,3 
        int sum = 0;
        int temp = 0;
        int index = 0;
        int k = 0;
        if (input.Length % 2 == 1)
        {
            foreach (var item in input)
            {
                if (k % 2 == 0)
                {
                    temp += item;
                }
                k++;
            }
        }
        for (int i = 0; i < input.Length; i++)
        {
            if (index == i && i > 0)
                continue;
            if (i == index + 1)
                continue;
            if (i == input.Length - 1)
            {
                sum += input[i];
                continue;
            }

            if (input[i] < input[i + 1])
            {
                sum += input[i + 1];
                index = i + 1;
            }
            else
            {
                sum += input[i];
                index = i;
            }
        }
        return sum > temp ? sum : temp;
    }
    public int GymCounter(string[] input)
    {
        //"Salı", "Perşembe", "Pazar", "Pazartesi", "Cumartesi", "Salı", "Pazartesi", "Pazartesi", "Çarşamba", "Salı"
        List<string> days = new List<string>(input);
        
        int currentDay=0;
        int lastDay = 0;
        int weekCounter = days.Count > 0 ? 1 : 0;
        foreach (var day in days)
        {
            currentDay = DayInteger(day);
            if (lastDay >= currentDay)
            {
                weekCounter++;
            }
            lastDay = currentDay;
        }
        return weekCounter;
    }
    public int DayInteger(string day)
    {
        switch (day)
        {
            case "Pazartesi":
                return 1;
            case "Salı":
                return 2;
            case "Çarşamba":
                return 3;
            case "Perşembe":
                return 4;
            case "Cuma":
                return 5;
            case "Cumartesi":
                return 6;
            case "Pazar":
                return 7;
            default:
                throw new InvalidOperationException("No day");
        }
    }
}
