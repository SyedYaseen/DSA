namespace DSA.Leetcode.Medium
{
    public class TwoSumII
    {
        public int[] Soln(int[] numbers, int target)
        {
            var result = new int[2];

            int i = 0;
            int j = numbers.Length - 1;

            while (i < j)
            {
                if (numbers[i] + numbers[j] < target) i++;
                else if (numbers[i] + numbers[j] > target) j--;
                else
                {
                    result = [i, j];
                    break;
                }
            }

            return result;
        }
    }
}


//var cl = new TwoSumII();

//var a = cl.Soln([2, 7, 11, 15], 9);
//var b = cl.Soln([2, 3, 4], 6);
//var c = cl.Soln([-1, 0], -1);