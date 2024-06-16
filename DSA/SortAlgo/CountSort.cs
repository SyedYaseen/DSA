namespace DSA.SortAlgo
{
    public class CountSort
    {
        public int[] Srt(int[] nums)
        {
            var result = new int[nums.Length];

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

            for(int i=0; i < highest; i++)
            {
                for(int j = freq[i]; j > 0; j--)
                {
                    result[i] = i;
                }
            }
            // Create array that has size of largest value in arr
            // Get the frequency of each number
            // Index = value of the number - Value = freq
            // Iterate through the arr and place the numbers on result



            return result;
        }
    }
}
