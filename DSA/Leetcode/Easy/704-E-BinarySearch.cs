namespace DSA.Leetcode.Easy
{
    public class BinarySearch
    {
        public int Soln(int[] nums, int target)
        {
            int min = 0;
            int max = nums.Length - 1;


            while (min <= max)
            {
                int middle = min + (max - min) / 2;

                if (target > nums[middle])
                    min = middle + 1;
                else if (target < nums[middle])
                    max = middle - 1;
                else
                    return middle;

            }
            return -1;
        }
    }
}
