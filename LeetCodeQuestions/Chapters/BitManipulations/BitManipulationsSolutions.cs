using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeQuestions.Chapters.BitManipulations
{
    public class BitManipulationsSolutions
    {
        public int AddBinary(int first,int second)
        {
            // 0+0=0,1+0=1,0+1=1,1+1=10
            int i =0;
            int rem = 0;
            string str = "";
            while (first!=0 || second!=0)
            {
                str += (first % 10 + second % 10 + rem) % 2;
                rem = (first % 10 + second %10 +rem) / 2;

                first /= 10;
                second /= 10;
            }
            if(rem!=0) 
            {
                StringBuilder sb = new StringBuilder(); 
                sb.Append(rem).Append(str);
                str = sb.ToString();
            }

            int res= int.Parse(str);

            return res;
        }
    }
}
