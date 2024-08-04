#pragma once
#include "../imports.h"
//vector<int> t1{ 2, 3, 6, 7 };
//vector<int> t2{ 1,2,3 };
//s.permute(t2);
class Solution {
public:
    vector<vector<int>> res;

    void shiftRight(int last, vector<int>& nums) {

        while (last > 0) {
            
            int temp = nums[last];
            for (int i = last - 1; i >= 0; i--) {
                nums[i + 1] = nums[i];
            }
            nums[0] = temp;


            res.push_back(nums);

            shiftRight(last - 1, nums);
        }
    }

    vector<vector<int>> permute(vector<int>& nums) {
        
        int sz = nums.size();
        

        int last = nums.size() - 1;

        shiftRight(last, nums);

        return res;
    }
};

