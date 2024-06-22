namespace DSA.Leetcode.Medium
{
    internal class MinimumRotatedSortedArray
    {
        public int Soln(int[] nums)
        {
            int l = 0;
            int r = nums.Length - 1;

            if (l == r || nums[l] < nums[r]) return nums[l];

            while (l < r)
            {
                int m = l + (r - l) / 2;
                if (r == l + 1)
                    return Math.Min(nums[l], nums[r]);
                                    
                else if (nums[l] < nums[m]) l = m;
                else if (nums[m] < nums[r]) r = m;
            }
            return -1;
        }

        public int TopSoln(int[] nums)
        {
            int left = 0;
            int right = nums.Length - 1;

            while (left < right)
            {
                int mid = left + (right - left) / 2;

                if (nums[mid] > nums[right])
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid;
                }
            }
            return nums[left];
        }
    }
}
