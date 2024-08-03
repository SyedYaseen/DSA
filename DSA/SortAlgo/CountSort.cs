namespace DSA.SortAlgo
{
    public class CountSort
    {
        public int[] Srt(int[] nums)
        {
            var highest = int.MinValue;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > highest) highest = nums[i];
            }


            var freq = new int[highest + 1];
            for (int i = 0; i < nums.Length; i++)
            {
                freq[nums[i]]++;
            }

            int j = 0;

            for (int i = 0; i < freq.Length; i++)
            {
                if (freq[i] != 0)
                {
                    while (freq[i] > 0)
                    {
                        nums[j] = i;
                        freq[i]--;
                        j++;
                    }
                }
            }
            // Create array that has size of largest value in arr
            // Get the frequency of each number
            // Index = value of the number - Value = freq
            // Iterate through the arr and place the numbers on result

            return nums;
        }
    }
}
