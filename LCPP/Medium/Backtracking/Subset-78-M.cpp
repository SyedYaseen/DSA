#include "../../imports.h"

class Solution {
public:
    vector<vector<int>> res {};
    int n;

    void backtrackAltNeetCodeSoln(vector<int> curr, vector<int>& nums, int idx) {
        if (n <= idx) {
            res.push_back(curr);
            return;
        }
        backtrack(curr, nums, idx+1);
        curr.push_back(nums[idx]);
        backtrack(curr, nums, idx+1);
    }

    void backtrack(vector<int> curr, vector<int>& nums, int idx) {
        res.push_back(curr);
        for (int i=idx; i < n; i++) {
            curr.push_back(nums[i]);
            backtrack(curr, nums, i+1);
            curr.pop_back();
        }
    }

    vector<vector<int>> subset(vector<int>& nums) {
        n = nums.size();        
        backtrackAltNeetCodeSoln(vector<int> {}, nums, 0);
        return res;
    }
};

int main() {
    Solution s;
    vector<int> a {1,2,3};
    auto res = s.subset(a);
    return 0;
}