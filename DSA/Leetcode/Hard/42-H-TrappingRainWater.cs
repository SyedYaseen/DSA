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
            int l = 0;
            int r = 1;
            int lastIndex = height.Length;

            // Initial l needs to be incremented until the next item
            // is not higher than the current one

            while (r < lastIndex)
            {
                while (l + 1 < lastIndex)
                {
                    if (height[l + 1] < height[l]) { r = l + 1; break; }
                    else l++;
                }

                /* 
                 After l is found, inc r until value increases for r compared to previous value
                 Also incrase r if its right next to l, because water can exist there
                */
                int blocks = 0;
                while (r + 1 < lastIndex)
                {

                    if (height[r + 1] < height[r]) // height[r] < height[l] &&
                    {
                        blocks += height[r];
                        r++;
                    }
                    else
                    {
                        r++;
                        int maxWallSize = Math.Min(height[l], height[r]);
                        blocks += maxWallSize;
                        result = ((r - l) * maxWallSize) - blocks;

                        // set new l value for next set
                        l = r;
                        blocks = 0;
                        continue;
                    }
                }

                //return result;
            }
            return result;
        }
    }
}
