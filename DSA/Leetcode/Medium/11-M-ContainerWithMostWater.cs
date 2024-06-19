using DSA.Leetcode.Medium;

namespace DSA.Leetcode.Medium
{
    public class ContainerWithMostWater
    {
        public int Soln(int[] height)
        {
            int result = 0;

            int i = 0;
            int j = height.Length - 1;

            while (i < j)
            {
                int area = (j - i) * Math.Min(height[i], height[j]);
                if (area > result) result = area;

                if (height[i] > height[j]) j--;
                else i++;
            }


            return result;
        }
    }
}


//var cl = new ContainerWithMostWater();


//var a = cl.Soln([1, 8, 6, 2, 5, 4, 8, 3, 7]); // 49
//var b = cl.Soln([1, 1]); // 1