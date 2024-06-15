using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Leetcode.Medium
{
    public class TopKFrequent
    {
        public int[] Soln(int[] nums, int k)
        {
            var result = new int[k];

            Dictionary<int, int> kv = new();
            for (int i = 0; i < nums.Length; i++)
            {
                if (kv.ContainsKey(nums[i])) kv[nums[i]]++;
                else kv[nums[i]] = 1;
            }

            List<int>[] freq = new List<int>[nums.Length + 1];

            foreach (var entry in kv)
            {
               
                if (freq[entry.Value] == null)
                {
                    freq[entry.Value] = new List<int>() { entry.Key };
                }
                else
                {
                    freq[entry.Value].Add(entry.Key);                }
            }

            for (int i = freq.Length - 1; i > 0 && k > 0; i--)
            {
                if(freq[i] != null)
                {
                    freq[i].ToList().ForEach(i =>
                    {
                        result[k - 1] = i;
                        k--;
                    });
                }

            }

            return result; 
        
        }

        // Create a dict which has num as key and value as frequency
        // Iterate through kv
        // Create a fixed size array/ list
        // Freq from dict is the index of the array
        // If 5 occurs once, 5 is saved on fixed array's index 1's list
        // If 6 also occurs once, 6 is saved on same list at index 1
        // When this fixed array is iterated in reverse, we get the most frequent numbers at the end
        // This is BASED ON the idea behind bucket sort



        public int[] Soln2(int[] nums, int k) 
        {
            Dictionary<int, int> kv = new();
            for (int i = 0; i < nums.Length; i++) 
            {
                if (kv.ContainsKey(nums[i])) kv[nums[i]]++;
                else kv[nums[i]] = 1;            
            }

            var s = new List<int>();
            var result = new int[k];
            while (k > 0)
            {
                int highest = kv.Keys.First();
                foreach (var entry in kv)
                {
                    if (entry.Value > kv[highest]) highest = entry.Key;
                }
                kv.Remove(highest);
                result[k-1]=highest;
                k -= 1;
            }

            return result;

        }
    }
}
