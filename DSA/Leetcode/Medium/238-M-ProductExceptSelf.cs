using DSA.Leetcode.Medium;

namespace DSA.Leetcode.Medium
{
    public class ProductExceptSelf
    {
        public int[] MySoln(int[] nums)
        {
            int[] prefix = new int[nums.Length];
            int[] suffix = new int[nums.Length];

            prefix[0] = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                prefix[i] = prefix[i - 1] * nums[i];
            }

            suffix[nums.Length - 1] = nums[nums.Length - 1];
            for (int i = nums.Length - 2; i > 0; i--)
            {
                suffix[i] = suffix[i + 1] * nums[i];
            }

            nums[0] = suffix[1];
            nums[nums.Length - 1] = prefix[nums.Length - 2];

            for (int i = 1; i < nums.Length - 1; i++)
            {
                nums[i] = prefix[i - 1] * suffix[i + 1];
            }

            return nums;
        }

        // for reference
        public int[] Soln(int[] nums)
        {
            var res = new int[nums.Length];

            int pre = 1;
            for (int i = 0; i < nums.Length; i++)
            {
                res[i] = pre;
                pre = nums[i] * pre;
            }

            int post = 1;
            for (int i = nums.Length - 1; i >= 0; i--)
            {
                res[i] = res[i] * post;
                post = post * nums[i];
            }
            return res;
        }


        //Same performance,but clearer

        public int[] Soln2(int[] nums)
        {
            // int[] result = new int[nums.Length];
            int[] prefix = new int[nums.Length];
            int[] suffix = new int[nums.Length];

            for (int i = 0; i < nums.Length; i++)
            {
                if (i == 0)
                {
                    prefix[i] = nums[i];
                    continue;
                }
                prefix[i] = prefix[i - 1] * nums[i];
            }

            for (int i = nums.Length - 1; i >= 0; i--)
            {
                if (i == nums.Length - 1)
                {
                    suffix[i] = nums[i];
                    continue;
                }
                suffix[i] = suffix[i + 1] * nums[i];
            }

            for (int i = 0; i < nums.Length; i++)
            {
                if (i == 0) nums[i] = suffix[i + 1];
                else if (i == nums.Length - 1) nums[i] = prefix[i - 1];
                else nums[i] = prefix[i - 1] * suffix[i + 1];
            }

            return nums;
        }
    }
}


//var cl = new ProductExceptSelf();
//var a = cl.Soln(new int[] { 1, 2, 3, 4 });
//// [1, 2, 6, 24]
//// [24, 24, 12, 4]

//// [24, 12, 8, 6]

//var b = cl.Soln(new int[] { -1, 1, 0, -3, 3 });
//// [0,0,9,0,0]