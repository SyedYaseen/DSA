namespace DSA.Leetcode.Easy
{
    internal class BuySellStock
    {
        public int Soln(int[] prices)
        {
            if (prices.Length == 0) return 0;

            int result = 0;
            int i = 0;
            int j = 1;

            while (i < j)
            {
                int current = 0;
                if (prices[i] > prices[j])
                {
                    if (current > result) result = current;
                }
                if (prices[i] > prices[j])
                {
                    i++;
                }
                else
                {
                    j++;
                }

            }
            return result;
        }
    }
}
