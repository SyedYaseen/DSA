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

                int i = k + 1; // So that I never need to start with the same item again. Will create duplicate values
                int j = nums.Length - 1;

                while (i < j)
                {
                    if (nums[i] + nums[j] + nums[k] > 0) j--;
                    else if (i == k || nums[i] + nums[j] + nums[k] < 0) i++;
                    else
                    {
                        result.Add([nums[i], nums[j], nums[k]]);

                        // Once this is complete, we move i, I dunno why - that rhymed, should've become a poet!
                        // Previously I had a break statement here, that would break once only one triplet for that k value is found
                        // Instead we want to exhaust every combo for i
                        // Even if j decreases to accomodate sum > 0, its fine because its a sorted array and for that combination, its not possible to get the sum = 0 
                        i++;
                        while (nums[i] == nums[i - 1] && i < j) i++; // to avoid duplicates
                    }
                }
            }

            return result;
        }
    }
}


//var cl = new ThreeSum();

//var a= cl.Soln([-1, 0, 1, 2, -1, -4]); // [-1,0,1] and [-1,-1,2]
//var b = cl.Soln([0, 1, 1]); // []
//var c = cl.Soln([0, 0, 0]); // 0
//var d = cl.Soln([1, 2, -2, -1]); // []
//var e = cl.Soln([-1, 0, 1, 2, -1, -4, -2, -3, 3, 0, 4]);
//var f = "1";
// [-4,-3,-2,-1,-1,0,0,1,2,3,4]
// [[-4,0,4],[-4,1,3],[-3,-1,4],[-3,0,3],[-3,1,2],[-2,-1,3],[-2,0,2],[-1,-1,2],[-1,0,1]]
// [-4,0,4] ,[-2,-1,3]
// [-3,-1,4], [-1,-1,2]