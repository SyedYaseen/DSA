
using DSA.Leetcode.Medium;

namespace DSA.Leetcode.Medium
{
    internal class SearchInSortedArray
    {
        Dictionary<string, Dictionary<int, string>> t = new();

        public int Soln(int[] nums, int target)
        {
            
            int l = 0;
            int r = nums.Length - 1;

            while (l <= r)
            {
                int m = l + (r - l) / 2;

                if (nums[m] == target) return m;
                else if (nums[l] <= nums[m]) // if left is sorted
                {
                    if (target >= nums[l] && target <= nums[m]) r = m;
                    else l = m + 1;
                }
                else if (nums[m] <= nums[r]) // right side is sorted
                {
                    if (target <= nums[r] && target >= nums[m]) l = m;
                    else r = m - 1; 
                }
            }

            return -1;

        }


            public int Soln2(int[] nums, int target)
        {
            // Get pivot
            // Perform bin search separately on each of the halves - only if value could be in there
            
            

            int l = 0;
            int r = nums.Length - 1;
            int pivot = 0;

            if (nums[l] > nums[r])
            {
                while (l < r)
                {
                    int m = l + (r - l) / 2;

                    if (r == l + 1)
                    {
                        pivot = nums[l] < nums[r] ? l : r;
                        break;
                    }

                    else if (nums[l] < nums[m]) l = m;
                    else if (nums[m] < nums[r]) r = m;
                    
                }

                if (nums[0] <= target && target <= nums[pivot - 1])
                    return Search(nums, 0, pivot - 1, target);
                else if (nums[pivot] <= target && target <= nums[nums.Length - 1])
                    return Search(nums, pivot, nums.Length - 1, target);
                else return -1;

            }
            else
            {
                return Search(nums, 0, nums.Length - 1, target);
            }
        }


        public int Search(int[] nums, int l, int r, int target)
        {
            while (l <= r)
            {
                int m = l + (r - l) / 2;
                if (nums[m] == target) return m;
                else if (nums[m] < target) l = m + 1;
                else if (nums[m] > target) r = m - 1;
            }
            return -1;
        }
    }
}


//var cl = new SearchInSortedArray();

//var a = cl.Soln([4, 5, 6, 7, 0, 1, 2], 0);
//var b = cl.Soln([4, 5, 6, 7, 0, 1, 2], 3);
//var c = cl.Soln([1], 0);
//var f = 'a';
