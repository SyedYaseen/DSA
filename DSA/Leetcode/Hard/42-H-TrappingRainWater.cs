using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Leetcode.Hard
{
    public class TrappingRainWater
    {
        public int Soln(int[] height)
        {
            int result = 0;
            int i = 0;
            int j = 1;
            bool left = false;
            // Make sure there is a wall to the left and to the right 
            // Find pockets 
            // Area = Min(height[j], height[i]) * (j - i) - current sections black boxes
            // If i and j are one block away move j
            // If i isnt on wall iterate until wall is reached to get to next section

            // To get to each section, 


            while (j < height.Length)
            {
                while (!left)
                {
                    i++;
                    left = true;
                }

                if (j == i + 1) j++;

                else (height[i] == 0) i++;
                
                
            }



            return result;
        }
    }
}
