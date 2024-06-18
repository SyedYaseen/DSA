
namespace DSA.Leetcode.Medium
{
    public class RotateArray
    {

        //O(1) extra space
        public void Soln(int[] nums, int k)
        {
            Reverse(nums);
            var a = nums;

        }

        public void Reverse(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                int lastIndex = nums.Length - 1 - i;
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
