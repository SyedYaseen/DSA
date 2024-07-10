#pragma once
#include <set>
class Solution {
public:

    // Two pointers - not working this is a complex algo
    int findDuplicate(vector<int>& nums) {
        // Use each item's value as index for next one

        int slow = nums[0];
        int fast = nums[1];

        while (fast != slow) {
            if (nums[fast] == nums[slow]) return nums[slow];
            slow = nums[slow];
            fast = nums[nums[fast]];
        }

        return nums[slow];
    }

    // Bad Soln
    //int findDuplicate(vector<int>& nums) {
    //    // Use each item's value as index for next one
    //    int current = nums[0];
    //    std::set<int> s;

    //    while (!s.count(current)) {
    //        s.insert(current);
    //        current = nums[current];
    //    }

    //    return current;
    //}
};

//vector<int> nums{ 1,3,4,2,2 };
//auto res = s.findDuplicate(nums);
//cout << res << endl;
//
//vector<int> nums2{ 3, 1, 3, 4, 2 };
//auto res2 = s.findDuplicate(nums2);
//cout << res2 << endl;