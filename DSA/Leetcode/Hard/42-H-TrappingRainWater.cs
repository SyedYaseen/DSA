
namespace DSA.Leetcode.Hard
{
    public class TrappingRainWater
    {
        public int Soln(int[] height)
        {
            int result = 0;
            int l = 0;
            int i = l+1;
            int r = i + 1;
            int lastIndex = height.Length;

       
            

            // Initial l needs to be incremented until the next item
            // is not higher than the current one

            while (l + 1 < lastIndex)
            {
                if (height[l + 1] < height[l]) { r = l + 1; break; }
                else l++;
            }

            /* 
            After l is found, inc r until height[r] >= height[l]
            Also incrase r if its right next to l, because water can exist there
            */
            int blocks = 0;
            while (r < lastIndex)
            {
                if (r+1 < lastIndex && height[r+1] < height[r])
                {
                    r++; 
                }
                if(height[r] <= height[l])
                {
                    blocks += height[r];
                    r++;
                }

                else
                {
                    result = ((r - l) * Math.Min(height[r], height[l])) - blocks;
                    l = r;
                    r++;
                                        
                }

                
            }


            return result;
        }


        public int Soln2(int[] height)
        {
            int result = 0;
            int l = 0;
            int r = 1;
            int lastIndex = height.Length;

            // Initial l needs to be incremented until the next item
            // is not higher than the current one

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
            while (r < lastIndex)
            {
                if (r + 1 < lastIndex && height[r + 1] < height[r] )  // height[r] < height[l] &&
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
                    while (l + 1 < lastIndex && height[l] == height[l + 1]) l++;
                    r = l + 1;
                    blocks = 0;
                }
            }

            return result;
        }
    }
}
