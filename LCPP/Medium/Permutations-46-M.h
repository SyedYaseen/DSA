#pragma once
#include "../imports.h"

class Solution {
public:
    vector<vector<int>> res;
    void backtrack(int start, vector<int>& nums) {
        if (start > nums.size() - 2) return;

        int temp = nums[nums.size() - 1];

        for (int i = nums.size() - 2; i >= start; i--) {
            nums[i + 1] = nums[i];
        }
        nums[0] = temp;

        res.push_back(nums);

        backtrack(start + 1, nums);


    }

    vector<vector<int>> permute(vector<int>& nums) {
        // move items by 1 pos until all combos are present,
        // keep doing recursively until index is
        
        backtrack(0, nums);

        return res;

    }
};

