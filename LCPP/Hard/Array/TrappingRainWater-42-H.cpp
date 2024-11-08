#include <bits/stdc++.h>
using namespace std;

class Solution
{
public:
    int trap(vector<int> &height)
    {
        int l = 0;
        int r = height.size() - 1;
        int maxL = height[l];
        int maxR = height[r];

        int res = 0;
        int sum = 0;

        while (l < r)
        {
            if (height[l] <= height[r])
            {
                l++;
                sum = min(maxL, maxR) - height[l];
                if (sum > 0)
                    res += sum;

                if (height[l] > maxL)
                    maxL = height[l];
            }
            else
            {
                r--;
                sum = min(maxL, maxR) - height[r];
                if (sum > 0)
                    res += sum;

                if (height[r] > maxR)
                    maxR = height[r];
            }
        }
        return res;
    }
};

int main()
{
    Solution s;
    vector<int> a = {0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1};
    cout << s.trap(a);
}