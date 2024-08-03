

namespace DSA.Leetcode.Medium
{
    public class RotateArray
    {

        //O(1) extra space
        public void Soln(int[] nums, int k)
        {
            Reverse(nums, 0, nums.Length - 1, GetMiddle(nums.Length));
            Reverse(nums, 0, k - 1, GetMiddle(k));
            Reverse(nums, k, nums.Length - 1, k + GetMiddle(nums.Length - k));
        }

        public int GetMiddle(int num)
        {
            return (int)Math.Floor((decimal)num / 2);
        }

        public void Reverse(int[] nums, int start, int end, int middle)
        {
            for (int i = start; i < middle; i++)
            {
                int lastIndex = end--;
                int temp = nums[i];
                nums[i] = nums[lastIndex];
                nums[lastIndex] = temp;
            }
        }


        //O(n) extra space
        public void Soln2(int[] nums, int k)
        {
            var temp = new int[nums.Length];

            for (int i = 0; i < nums.Length; i++)
            {
                int movedIndex = i + k;
                if (movedIndex >= nums.Length) movedIndex = movedIndex - nums.Length;

                temp[movedIndex] = nums[i];
            }
            nums = temp;
        }
    }
}
