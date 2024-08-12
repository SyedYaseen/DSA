#include "../../imports.h"

class Solution {
public:
    set<vector<int>> s;
    void backtrack(vector<int> current, int index, vector<int>& nums) {
        if (nums.size() == index) {
            sort(current.begin(), current.end());
            s.insert(current);
            return;
        }
        int nonIncludeIndex = index + 1;
        while (nonIncludeIndex < nums.size() && nums[nonIncludeIndex] == nums[index]) nonIncludeIndex++;

        
        backtrack(current, nonIncludeIndex, nums); // not adding the value
        current.push_back(nums[index]);
        backtrack(current, index+1, nums); // adding the value

    }

    vector<vector<int>> subsetsWithDup(vector<int>& nums) {
        sort(nums.begin(), nums.end());
        
        backtrack(vector<int> {}, 0,  nums);

        
        vector<vector<int>> res(s.size());
        // res.assign(s.begin(), s.end());
        copy(s.begin(), s.end(), res.begin());

        return res;
    }
};

int main() {
    Solution s;
    vector<int> a {1,2,2};
    auto res = s.subsetsWithDup(a);
    return 0;
}