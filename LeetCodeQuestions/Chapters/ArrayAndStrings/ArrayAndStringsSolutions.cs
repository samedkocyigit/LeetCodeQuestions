using System.Security.Cryptography.X509Certificates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.ComponentModel.DataAnnotations;

namespace LeetCodeQuestions.Chapters.ArrayAndStrings
{
    public class ArrayAndStringsSolutions
    {
        public int[] MergeSortedArr(int[] nums1, int m, int[] nums2, int n)
        {
            for (int j = 0, i=m; j < n; j++,i++)
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

            for(int i=0; i < arr.Length; i++)
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
            for (int i = 0; i<arr.Length; i++)
            {
                for(int j = 0; j < arr.Length; j++)
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

        public int[] RotateArray(int[] arr,int k)
        {
            int lastElement;
            for (int i =0; i < k; i++)
            {
                lastElement= arr[arr.Length-1];
                for (int j=arr.Length-1; j >0;j--)
                {
                    arr[j]= arr[j-1];    
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
                    if(j>i)
                        tempArr.Add(arr[j] - arr[i]);
                }
            }
            tempArr.Sort();
            tempArr.Reverse();
            profits = (int)tempArr[0];
            if(profits<0)
                profits= 0;

            return profits;
        }

        public int BestProfitTwo(int[] arr)
        {
            int profit = 0;
            int buyDay = 0, sellDay = 0;

            if(arr.Length==1)
                return 0;

            for (int i = 1; i < arr.Length-1; i++)
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
            int length=arr.Length; 

            for (int j=1; j<length;)
            {
                index = arr[j];
                if (index == 0 || (j + index) > (length - 1)) { return false; }
                                
                j=j+index;
                
                if(j==length-1) { return true; }
            }
 
            return false;
        }

        public int JumpGame2(int[] arr)
        {
            int index;
            int length=arr.Length;
            int counter = 1;

            for(int j=1; j < length;)
            {
                index = arr[j];

                if(index == 0 || (j+index) > (length - 1)) { return 0; }

                j=j+index;
                counter++;
                if(j==length-1) { return counter; }
            }
            return 0;
        }

        public int[] arrMultiplication(int[] arr) 
        {  
            int[] outputArr= new int[arr.Length];
            int temp = 1;   
            for(int i = 0; i < arr.Length; i++)
            {
                for(int j =0; j<arr.Length; j++)
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
            int i = 0,j=-1,index=0;
            bool flag = false;
            do
            {
                if(arrStation.Sum()< arrCost.Sum()) { return -1; }
                if (arrStation[i] >= arrCost[i] || gas >= arrCost[i])
                {
                    if (gas == 0) { gas += arrStation[i]; }
                    else { gas += arrStation[i] - arrCost[j]; }

                    index++;
                    if (index == arrCost.Length) { flag = true;}
                }

                j++; if (j >= length) { j = 0; }
                i++; if (i >= length) { i = 0; }
            } while (flag == false);
            return i;
        }

        public int RainTrap(int[] arr)
        {
            int length = arr.Length;
            int sum =0;
            int leftPose = 1;
            int rightPose = length-2;
            int leftMax = arr[0];
            int rightMax = arr[length-1];

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
            int result=0;
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

            for(int i = input.Length - 1; i >= 0; i--)
            {
                if (romanEmpire[input[i]]>=temp)
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
            int length = input.Length-1;
            int counter= 0;

            for (int i = length; i >= 0; i--)
            {
                if (input[i] != ' ') 
                    counter++;
                else
                    break;
            }
            return counter;
        }




























    }
}
