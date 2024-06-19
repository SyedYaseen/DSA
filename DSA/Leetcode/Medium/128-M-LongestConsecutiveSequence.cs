
using DSA.Leetcode.Medium;

namespace DSA.Leetcode.Medium
{
    public class LongestConsecutiveSequence
    {
        // Based on high leetcode soln
        public int Soln(int[] nums)
        {
            if (nums.Length == 0) return 0;
           
            Array.Sort(nums);
            int count = 1;
            int maxCount = 1; 
            for (int i = 0; i < nums.Length - 1; i++)
            {
                if (nums[i] + 1 == nums[i + 1])
                {
                    count++;
                    if (count > maxCount) maxCount = count;
                }
                else if (nums[i] != nums[i + 1]) // missed this part
                    count = 1;
            }

            return maxCount;
        }

        //https://youtu.be/P6RZZMu_maU
        public int Soln3(int[] nums)
        {
            var set = new HashSet<int>(nums);
            var result = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (!set.Contains(nums[i] - 1))
                {
                    int count = 1;
                 
                    while (set.Contains(nums[i] + count))
                    {
                        count++;
                    }
                    if(count > result ) result = count;
                }
            }

            return result;
        }

            // Fails runtime for very large numbers
            public int Soln2(int[] nums)
        {
            if(nums.Length <=1 ) return nums.Length;

            int result = 0;
            int highest = int.MinValue;
            int lowest = int.MaxValue;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > highest) highest = nums[i];
                if (nums[i] < lowest) lowest = nums[i];
            }

            int[] freqPositive = new int[highest + 1];
            int[] freqNegative = new int[Math.Abs(lowest) + 1];

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] >= 0) freqPositive[nums[i]]++;
                else freqNegative[Math.Abs(nums[i])]++; 
            }

            int current = 0;
            lowest = Math.Abs(lowest);

            for (int i = lowest; i > 0; i--)
            {
                if (freqNegative[i] != 0)
                {
                    current++;
                    if (current > result) result = current;
                }
                else current = 0;
            }

            for (int i = 0; i < freqPositive.Length; i++)
            {
                if (freqPositive[i] != 0)
                {
                    current++;
                    if (current > result) result = current;
                }
                else current = 0;
            }

            return result; 
        }
    }
}


//var cl = new LongestConsecutiveSequence();
////cl.Soln([0, -1]);
//cl.Soln([1, 2, 0, 1]);
//cl.Soln([0, -1, -5, -4, -3]); // 
//cl.Soln([0, 1, 2, 4, 8, 5, 6, 7, 9, 3, 55, 88, 77, 99, 999999999]);
//cl.Soln([100, 4, 200, 1, 3, 2]); //4
//cl.Soln([0, 3, 7, 2, 5, 8, 4, 6, 0, 1]); //9