using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Leetcode.Medium
{
    public class DailyTemperatures
    {
        public int[] Soln2(int[] temperatures)
        {
            var st = new Stack<int>();



        }


            // Fails for an absurd testcase
            public int[] Soln2(int[] temperatures)
        {
            if (temperatures.Length <= 1) return [0]; 
            int i = 0;
            int j =  i + 1;

            while (i < temperatures.Length - 1)
            {
                if (j == temperatures.Length)
                {
                    temperatures[i] = 0;
                    i++;
                    j = i + 1;
                }
                else if (temperatures[j] > temperatures[i])
                {
                    temperatures[i] = j - i;
                    i++;
                    j = i + 1;
                }
                else j++;
            }
            temperatures[temperatures.Length - 1] = 0;
            return temperatures;
        }
    }
}
