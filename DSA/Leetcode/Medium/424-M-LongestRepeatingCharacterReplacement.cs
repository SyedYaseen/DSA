using DSA.Leetcode.Medium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Leetcode.Medium
{
    internal class LongestRepeatingCharacterReplacement
    {
        public int Soln(string s, int k)
        {
            // Followed NC
            int result = 0;
            var h = new Dictionary<char, int>();
            int highest = 0;

            int i = 0;
            int j = 0;

            while (i <= j && j < s.Length)
            {

                if (h.ContainsKey(s[j])) h[s[j]] += 1;
                else h.Add(s[j], 1);
                
                if (h[s[j]] > highest) highest = h[s[j]];

                if (j - i + 1 - highest <= k)
                {
                    result = j - i + 1;
                    j++;
                } else
                {
                    h[s[i]] -= 1;
                    i++;
                    j++;
                }
            }


            return result;



        }
    }
}

//var cl = new LongestRepeatingCharacterReplacement();
//var a = cl.Soln("ABAB", 2); //4
//var b = cl.Soln("AABABBA", 1); //4