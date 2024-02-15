using System;
using System.Collections;
namespace LeetCodeQuestions.Chapters.OneDimensionalDP;

public class OneDimensionalDPSolutions
{
	public int ClaimbingStairs(int str)
	{
		int output=str-1;
		int current = 0;
		ArrayList arrayList = new ArrayList();
		arrayList.Add(1);
        arrayList.Add(2);

		for (int i = 2; i < str; i++)
		{
            current = (int)arrayList[i - 1] + (int)arrayList[i - 2];
			arrayList.Add(current);
			current = 0;
		}	
        return (int)arrayList[output];
	}
}

