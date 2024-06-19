using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Leetcode.Medium
{
    public class ThreeSum
    {
        public IList<IList<int>> Soln(int[] nums)
        {
            
            var result = new List<IList<int>>();
            Array.Sort(nums);
            for (int k = 0; k < nums.Length; k++)
            {
                if (k > 0 && nums[k - 1] == nums[k]) continue;
                
                int i = 0;
                int j = nums.Length - 1;

                while (i < j)
                {
                    if (j == k || nums[i] + nums[j] + nums[k] > 0) j--;
                    else if (i == k || nums[i] + nums[j] + nums[k] < 0) i++;
                    else 
                    {
                        result.Add([nums[i], nums[j], nums[k]]);
                        break;
                    }
                }
            }

            return result;
        }
    }
}
