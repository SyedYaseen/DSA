#pragma once
#include "../imports.h"

#include <algorithm>
#include <set>

class Solution {

public:

    vector<vector<int>> result;

    void backtrack(int index, int current, vector<int>& path, vector<int>& candidates) {
        if (current < 0 || index >= candidates.size()) return;
        if (current == 0) { result.push_back(path); return; }

         
        path.push_back(candidates[index]);
        backtrack(index, current - candidates[index], path, candidates);
        path.pop_back();
        backtrack(index + 1, current, path, candidates);

    }

    vector<vector<int>> combinationSum(vector<int>& candidates, int target) {
        vector<int> path;
        backtrack(0, target, path, candidates);

        return result;
    }
};


//
//void backtrackNaiveSomeIssue(int current, vector<int>& path, vector<int>& candidates) {
//
//    if (current < 0) return;
//
//    if (current == 0) {
//        sort(path.begin(), path.end());
//        s.insert(path);
//        return;
//    }
//
//    for (int i = 0; i < candidates.size(); i++) {
//        path.push_back(candidates[i]);
//
//        backtrack(current - candidates[i], path, candidates);
//        path.pop_back();
//
//    }
//}