#include "../../imports.h"

// Neet code soln - incomplete
// class Solution {
// public:
//     vector<vector<int>> res;

//     void backtrack(vector<int> nums) {
//         if (nums.size() == 1) { res.push_back(nums); return; }


//         vector<int> n (nums.begin()+1, nums.end());
//         backtrack(n);

//         for (int i = 0; i < res.size(); i++) {
//             for (int j = 0; j < res[i].size(); j++) {
//                 res[i][j].insert(res[i][j].begin() + j)

//             }
//         } 
//     }

//     vector<vector<int>> permute(vector<int>& nums) {
//         backtrack(nums);
//         return res;
//     }
// };


// Best soln on leetcode
class Solution {
public:
    vector<vector<int>> res;

    void backtrack(vector<int>& nums, int start) {
        if (start == nums.size()) {
            res.push_back(nums);
            return;
        }

        for (int i = start; i < nums.size(); i++) {
            swap(nums[start], nums[i]);  // Swap the current element with the starting element
            backtrack(nums, start + 1);  // Recursively generate permutations for the remaining elements
            swap(nums[start], nums[i]);  // Backtrack by restoring the original order
        }
      }

    vector<vector<int>> permute(vector<int>& nums) {
        backtrack(nums, 0);
        return res;
    }
};


// https://youtu.be/Nabbpl7y4Lo?si=qRNUJ04oHSeHckGk - With bool array
// class Solution {
// public:
//     vector<vector<int>> res;

//     void backtrack(vector<int>& current, vector<bool>& s, vector<int>& nums) {
//         if(current.size() == nums.size()) {
//             res.push_back(current); return;
//         }

//         for (int i= 0; i < nums.size(); i++) {
//             if (!s[i]) {
//                 s[i] = true;
//                 current.push_back(nums[i]);
                
//                 backtrack(current, s, nums);

//                 s[i] = false;
//                 current.pop_back();

//             }
//         }
//     }


//     vector<vector<int>> permute(vector<int>& nums) {
//         vector<int> current;
//         vector<bool> s(nums.size(), false);
//         backtrack(current, s, nums);

//         return res;
//     }
// };

// With set
// class Solution {
// public:
//     vector<vector<int>> res;
//     set<int> s;

//     void backtrack(vector<int>& current, vector<int>& nums) {
//         if(current.size() == nums.size()) {
//             res.push_back(current); return;
//         }

//         for (int i= 0; i < nums.size(); i++) {
//             if (!s.contains(nums[i])) {
//                 s.insert(nums[i]);
//                 current.push_back(nums[i]);
                
//                 backtrack(current, nums);

//                 s.erase(nums[i]);
//                 current.pop_back();

//             }
//         }
//     }


//     vector<vector<int>> permute(vector<int>& nums) {
//         vector<int> current;
//         backtrack(current, nums);

//         return res;
//     }
// };


int main() {
    Solution s;
    vector<int> a {1,2,3};
    s.permute(a);
}