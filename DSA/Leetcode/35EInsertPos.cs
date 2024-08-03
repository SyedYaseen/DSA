public class InsertPosition
{
    public int InsertPos(int[] nums, int target)
    {

        int rev = nums.Length - 1;

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] == target || nums[i] > target)
                return i;
            if (nums[rev] == target)
                return rev;
            else if (nums[rev] < target)
                return rev + 1;
            rev--;
        }

        return 0;
    }

    public int InsertPos2(int[] nums, int target)
    {
        if (target < nums[0])
            return 0;
        else if (target > nums[nums.Length - 1])
            return nums.Length;

        int left = 0;
        int right = nums.Length - 1;

        while (left <= right)
        {
            int median = left + (right - left) / 2;

            if (target == nums[left])
                return left;
            else if (target == nums[right])
                return right;
            else if (target == nums[median])
                return median;
            else if (left == median)
                return left + 1;
            else if (target < nums[median])
                right = median;
            else if (target > nums[median])
                left = median;
        }

        throw new Exception("Cant find solution");
    }
}


